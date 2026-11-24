
public static class CustomFunction{
    public static IEnumerable<Control> GetAllChildControls(Control parent) {
        foreach (Control child in parent.Controls) {
            yield return child;
            foreach (Control nested in GetAllChildControls(child)) {
                yield return nested;
            }
        }
    }
}
