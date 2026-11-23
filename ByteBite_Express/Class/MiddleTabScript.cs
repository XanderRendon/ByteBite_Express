using System;
using System.Windows.Forms;

public class MiddleTabScript {
    private TableLayoutPanel? _grid;
    public void Run(TableLayoutPanel grid3x3) {
        _grid = grid3x3;
        AppState.SelectedValueChanged += RefreshGrid;
        RefreshGrid();
    }
    private void RefreshGrid() {
        if (_grid == null) return;

        int categoryId = AppState.SelectedValue;
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
        _grid.ResumeLayout();
    }
    private void ClearGrid() {
        foreach (Control ctrl in _grid!.Controls) {
            ctrl.Dispose();
        }
        _grid.Controls.Clear();
    }

    private void OnCardSelected(int categoryId, int itemId) {
        // Equivalent to [categoryId, itemId], e.g. [1, 2]
        MenuItemData? selected = MenuData.GetItem(categoryId, itemId);
        if (selected != null)
        {
            // Add selected item to cart / update state here
        }
    }
}