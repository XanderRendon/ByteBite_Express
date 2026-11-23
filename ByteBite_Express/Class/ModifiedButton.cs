using System;
using System.Drawing;
using System.Windows.Forms;

public class TouchTriggerButton : Button
{
    public TouchTriggerButton()
    {
        SetStyle(ControlStyles.Selectable, false);
        SetStyle(ControlStyles.UserMouse, true);
        TabStop = false;
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0; // Optional: remove border completely
        FlatAppearance.MouseOverBackColor = Color.Transparent;
        FlatAppearance.MouseDownBackColor = Color.Transparent;
    }

    protected override bool ShowFocusCues => false;

    protected override void OnMouseDown(MouseEventArgs mevent)
    {
        // Do not call base.OnMouseDown if you want to avoid default focus/push state,
        // or call base and immediately clear focus from this control:
        base.OnMouseDown(mevent);
        Parent?.Focus();
    }
}