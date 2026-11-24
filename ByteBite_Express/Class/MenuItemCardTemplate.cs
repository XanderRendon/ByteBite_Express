using System;
using System.Drawing;
using System.Windows.Forms;

public class MenuItemCard : Panel {
    public int CategoryId { get; }
    public int ItemId { get; }
    public event Action<int, int>? ItemSelected;
    public MenuItemCard(int categoryId, int itemId, MenuItemData data)
    {
        CategoryId = categoryId;
        ItemId = itemId;

        Dock = DockStyle.Fill;
        Margin = new Padding(4);
        BackColor = Color.FromArgb(250, 246, 218);
        Cursor = Cursors.Hand;

        var table = new TableLayoutPanel
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            Dock = DockStyle.Fill,
            RowCount = 3,
            ColumnCount = 1,
            Cursor = Cursors.Hand
        };

        var iconBox = new PictureBox
        {
            Image = data.Icon,
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Top,
            Height = 64,
            Cursor = Cursors.Hand,
        };

        var nameLabel = new Label
        {
            Text = $"{data.Name}",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Cursor = Cursors.Hand,
            BackColor = Color.FromArgb(250, 246, 238),
            Font = new Font("Bahnschrift SemiCondensed", 8F, FontStyle.Bold),
        };
        var priceLabel = new Label
        {
            Text = $"₱{data.Price:0}",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Cursor = Cursors.Hand,
            BackColor = Color.FromArgb(250, 246, 238),
            Font = new Font("Bahnschrift SemiCondensed", 7F)
        };
        table.RowStyles.Clear();
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        table.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));

        table.Controls.Add(iconBox);
        table.Controls.Add(nameLabel);
        table.Controls.Add(priceLabel);
        Controls.Add(table);

        // Clicking either the card or its child controls triggers [categoryId, itemId]
        void OnClick(object? s, EventArgs e) => ItemSelected?.Invoke(CategoryId, ItemId);
        Click += OnClick;
        table.Click += OnClick;
        iconBox.Click += OnClick;
        nameLabel.Click += OnClick;
        priceLabel.Click += OnClick;
    }
    public void SetSelected(bool isSelected, Color normalBack, Color selectedBack, Color normalFore, Color selectedFore) {
        Color cardBack = isSelected ? selectedBack : normalBack;
        Color textColor = isSelected ? selectedFore : normalFore;

        BackColor = cardBack;
        ForeColor = textColor;

        // Update child labels too so they don't stay stuck on the hardcoded cream color
        foreach (Control child in CustomFunction.GetAllChildControls(this)) {
            if (child is Label lbl) {
                lbl.BackColor = cardBack;
                lbl.ForeColor = textColor;
            }
        }
    }
}
