using System;
using System.Diagnostics;
using System.Windows.Forms;

public class MiddleTabScript {
    private TableLayoutPanel? _grid;
    private Label? CategoryDisplayLabel;
    private TouchTriggerButton[] categoryButtons = Array.Empty<TouchTriggerButton>();
    private readonly Color _normalBackColor = Color.FromArgb(250, 246, 218);
    private readonly Color _selectedBackColor = Color.FromArgb(217, 155, 130);
    private readonly Color _normalForeColor = Color.FromArgb(217, 155, 130);
    private readonly Color _selectedForeColor = Color.FromArgb(250, 246, 218);
    public void Run(TableLayoutPanel grid3x3, Label displayLabel, TouchTriggerButton[] buttons) {
        categoryButtons = buttons;
        _grid = grid3x3;
        CategoryDisplayLabel = displayLabel;
        AppState.SelectedValueChanged += RefreshGrid;
        AppState.SelectedItemChanged += RefreshGrid;
        RefreshGrid();
    }
    private void RefreshGrid() {
        if (AppState.SelectedCategoryValue < 1 || AppState.SelectedCategoryValue > categoryButtons.Length) { return;}
        CategoryDisplayLabel.Text = categoryButtons[AppState.SelectedCategoryValue - 1].Text;
        if (_grid == null) return;  

        int categoryId = AppState.SelectedCategoryValue;
        if (!MenuData.Categories.TryGetValue(categoryId, out var itemsDict)) {
            ClearGrid();
            return;
        }

        _grid.SuspendLayout();
        ClearGrid();

        int maxCells = _grid.ColumnCount * _grid.RowCount; // 9 for a 3x3 grid
        int index = 0;

        foreach (var pair in itemsDict) {
            if (index >= maxCells) break;

            int itemId = pair.Key;
            MenuItemData data = pair.Value;

            var card = new MenuItemCard(categoryId, itemId, data);
            card.ItemSelected += OnCardSelected;

            int col = index % _grid.ColumnCount;
            int row = index / _grid.ColumnCount;
            _grid.Controls.Add(card, col, row);
            index++;
        }
        foreach (Control control in CustomFunction.GetAllChildControls(_grid)) {
            if (control is MenuItemCard card) {
                bool isSelected = AppState.IsItemSelected(card.CategoryId, card.ItemId);
                card.SetSelected(isSelected, _normalBackColor, _selectedBackColor, _normalForeColor, _selectedForeColor);
            }
        }
        _grid.ResumeLayout();
    }
    private void ClearGrid() {
        foreach (Control ctrl in _grid!.Controls) {
            ctrl.Dispose();
        }
        _grid.Controls.Clear();
    }

    private void OnCardSelected(int categoryId, int itemId) {
        MenuItemData? selected = MenuData.GetItem(categoryId, itemId);
        if (selected != null) {
            AppState.SetSelectedItem(categoryId, itemId);
            Debug.WriteLine($"Category: {AppState.SelectedItem[0]}, Item: {AppState.SelectedItem[1]}");
        }
    }
}