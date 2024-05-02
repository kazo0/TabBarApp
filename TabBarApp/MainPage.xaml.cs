namespace TabBarApp;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

	private void TopTabSelectionChanged(TabBar sender, TabBarSelectionChangedEventArgs args)
	{
		if (args.NewItem is TabBarItem item) 
		{
			TopTab.Text = item.Content as string;
		}
    }

	private void BottomTabSelectionChanged(TabBar sender, TabBarSelectionChangedEventArgs args)
	{
		if (args.NewItem is TabBarItem item)
		{
			BottomTab.Text = item.Content as string;
		}
	}
}
