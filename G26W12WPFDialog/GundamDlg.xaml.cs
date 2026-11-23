using System.Windows;
using System.Windows.Controls;

namespace G26W12WPFDialog;

public partial class GundamDlg : Window
{
    public GundamDlg()
    {
        InitializeComponent();
    }

    public string GundamName => NameInput.Text.Trim();
    public string ModelName => ModelInput.Text.Trim();
    public string Faction => ((ComboBoxItem)FactionInput.SelectedItem).Content.ToString()!;

    private void OnConfirm(object sender, RoutedEventArgs e)
    {
        if (GundamName.Length == 0 || ModelName.Length == 0)
        {
            MessageBox.Show(this, "이름과 모델을 모두 입력하세요");
            return;
        }
        DialogResult = true;
    }
}
