using System;
using System.Drawing;
using System.Windows.Forms;

public class LeftTabScript
{
    private TouchTriggerButton[] categoryButtons = Array.Empty<TouchTriggerButton>();
    private Label? CategoryDisplayLabel;
    public void Run(TouchTriggerButton[] buttons, Label displayLabel) {
        categoryButtons = buttons;
        CategoryDisplayLabel = displayLabel;
        AppState.SelectedValueChanged += SetSelectedButtonGroup;
        for (int i = 0; i < categoryButtons.Length; i++) {
            int categoryId = i + 1;
            categoryButtons[i].Click += (sender, e) => CategoryBtn_Click(categoryId);
        }
        SetSelectedButtonGroup();
    }
    private void SetSelectedButtonGroup() {
        if (AppState.SelectedValue < 1 || AppState.SelectedValue > categoryButtons.Length) {return;}
        foreach (TouchTriggerButton btn in categoryButtons) {
            btn.Enabled = true;
            btn.BackColor = Color.Transparent;
        }
        categoryButtons[AppState.SelectedValue - 1].Enabled = false;
        categoryButtons[AppState.SelectedValue - 1].BackColor = Color.FromArgb(245, 238, 224);
        CategoryDisplayLabel.Text = categoryButtons[AppState.SelectedValue - 1].Text;
    }
    private void CategoryBtn_Click(int value) {
        AppState.SelectedValue = value;
    }
}