public static class AppState {
    private static int _selectedCategoryValue = 1;
    private static int[] _selectedItem = new[] { 0, 0 };
    public static event Action? SelectedValueChanged;
    public static event Action? SelectedItemChanged;

    public static int SelectedCategoryValue
    {
        get => _selectedCategoryValue;
        set
        {
            if (_selectedCategoryValue == value) return;
            _selectedCategoryValue = value;
            SelectedValueChanged?.Invoke();
        }
    }
    public static int[] SelectedItem
    {
        get => _selectedItem;
        set
        {
            int categoryId = (value != null && value.Length > 0) ? value[0] : 0;
            int itemId = (value != null && value.Length > 1) ? value[1] : 0;

            // Normalize to { 0, 0 } if either ID is <= 0
            var next = (categoryId > 0 && itemId > 0)
                ? new[] { categoryId, itemId }
                : new[] { 0, 0 };

            if (_selectedItem.SequenceEqual(next)) return;
            _selectedItem = next;
            SelectedItemChanged?.Invoke();
        }
    }
    public static void SetSelectedItem(int categoryId, int itemId) {
        SelectedItem = (categoryId > 0 && itemId > 0)
            ? new[] { categoryId, itemId }
            : new[] { 0, 0 };
    }
    public static void SetSelectedItem(int itemId) {
        SetSelectedItem(_selectedCategoryValue, itemId);
    }
    public static void ClearSelectedItem() {
        SelectedItem = new[] { 0, 0 };
    }
    public static bool IsItemSelected(int categoryId, int itemId) {
        return _selectedItem.Length >= 2 &&
               _selectedItem[0] == categoryId &&
               _selectedItem[1] == itemId;
    }
}