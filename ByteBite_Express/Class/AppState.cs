public static class AppState {
    private static int _selectedValue = -1;
    public static event Action? SelectedValueChanged;
    public static int SelectedValue {
        get => _selectedValue;
        set {
            if (_selectedValue == value) return;
            _selectedValue = value;
            SelectedValueChanged?.Invoke();
        }
    }
}