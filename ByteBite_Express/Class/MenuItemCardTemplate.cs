using System;
using System.Drawing;
using System.Windows.Forms;

public class MenuItemCard : Panel {
    public int CategoryId { get; }
    public int ItemId { get; }
    public event Action<int, int>? ItemSelected;
    public MenuItemCard(int categoryId, int itemId, MenuItemData data) {
        CategoryId = categoryId;
        ItemId = itemId;

        Dock = DockStyle.Fill;
        Margin = new Padding(4);
        BackColor = Color.FromArgb(245, 238, 224);
        Cursor = Cursors.Hand;

        var iconBox = new PictureBox {
            Image = data.Icon,
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Top,
            Height = 64
        };

        var titleLabel = new Label {
            Text = $"{data.Name}\n₱{data.Price:0}",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };

        Controls.Add(titleLabel);
        Controls.Add(iconBox);

        // Clicking either the card or its child controls triggers [categoryId, itemId]
        void OnClick(object? s, EventArgs e) => ItemSelected?.Invoke(CategoryId, ItemId);
        Click += OnClick;
        iconBox.Click += OnClick;
        titleLabel.Click += OnClick;
    }
}
