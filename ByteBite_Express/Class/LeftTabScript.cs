using System;
using System.Drawing;
using System.Windows.Forms;

public class LeftTabScript
{
    private TouchTriggerButton[] categoryButtons = Array.Empty<TouchTriggerButton>();
    public void Run(TouchTriggerButton[] buttons) {
        categoryButtons = buttons;
        AppState.SelectedValueChanged += SetSelectedButtonGroup;
        for (int i = 0; i < categoryButtons.Length; i++) {
            int categoryId = i + 1;
            categoryButtons[i].Click += (sender, e) => CategoryBtn_Click(categoryId);
        }
        SetSelectedButtonGroup();
    }
    private void SetSelectedButtonGroup() {
        if (AppState.SelectedCategoryValue < 1 || AppState.SelectedCategoryValue > categoryButtons.Length) {return;}
        foreach (TouchTriggerButton btn in categoryButtons) {
            btn.Enabled = true;
            btn.BackColor = Color.Transparent;
        }
        categoryButtons[AppState.SelectedCategoryValue - 1].Enabled = false;
        categoryButtons[AppState.SelectedCategoryValue - 1].BackColor = Color.FromArgb(245, 238, 224);
    }
    private void CategoryBtn_Click(int value) {
        AppState.SelectedCategoryValue = value;
    }
}