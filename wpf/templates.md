# Data Template
Sposób na przechowanie danych w XAML. Alternatywa dla klasycznego przypisania. 
## Kod
### Podstawowy kod (z bindingiem):
```xml
<DataTemplate>
    <TextBlock Text="{Binding Name}" />
</DataTemplate>
```
### Przykład z ListBox:
```xml
<ListBox Width="400" Margin="10"
         ItemsSource="{Binding Source={StaticResource myTodoList}}"> <!--  <Window.Resources>    <local:Tasks x:Key="myTodoList"/> </Window.Resources> dzięki temu możemy pobrać dane z .cs-->
   <ListBox.ItemTemplate> <!--Dzieki temu możemy jako źródło dać cały DataTemplate-->
     <DataTemplate>
       <StackPanel>
         <TextBlock Text="{Binding Path=TaskName}" />
         <TextBlock Text="{Binding Path=Description}"/>
         <TextBlock Text="{Binding Path=Priority}"/>
       </StackPanel>
     </DataTemplate>
   </ListBox.ItemTemplate>
 </ListBox>
```
### Przykład z Window.Resource:
```xml
<Window.Resources>
<DataTemplate x:Key="myTaskTemplate"> <!-- x:Key konieczne by połączyć z ListBox ItemTemplate -->
  <StackPanel>
    <TextBlock Text="{Binding Path=TaskName}" />
    <TextBlock Text="{Binding Path=Description}"/>
    <TextBlock Text="{Binding Path=Priority}"/>
  </StackPanel>
</DataTemplate>
</Window.Resources>
<!--Później w kodzie z np. ListBox-->
<ListBox Width="400" Margin="10"
         ItemsSource="{Binding Source={StaticResource myTodoList}}"
         ItemTemplate="{StaticResource myTaskTemplate}"/>
```
### Zamiast x:Key można też dać:
```xml
<DataTemplate DataType="{x:Type local:Task}"> <!--X:Type local:nazwa_modelu w tym przypadku Task -->
  <StackPanel>
    <TextBlock Text="{Binding Path=TaskName}" />
    <TextBlock Text="{Binding Path=Description}"/>
    <TextBlock Text="{Binding Path=Priority}"/>
  </StackPanel>
</DataTemplate>
```
### Przykład z customowym DataTemplate:
```xml
<DataTemplate x:Key="myTaskTemplate">
  <Border Name="border" BorderBrush="Aqua" BorderThickness="1"
          Padding="5" Margin="5">
    <Grid>
      <Grid.RowDefinitions>
        <RowDefinition/>
        <RowDefinition/>
        <RowDefinition/>
      </Grid.RowDefinitions>
      <Grid.ColumnDefinitions>
        <ColumnDefinition />
        <ColumnDefinition />
      </Grid.ColumnDefinitions>
      <TextBlock Grid.Row="0" Grid.Column="0" Text="Task Name:"/>
      <TextBlock Grid.Row="0" Grid.Column="1" Text="{Binding Path=TaskName}" />
      <TextBlock Grid.Row="1" Grid.Column="0" Text="Description:"/>
      <TextBlock Grid.Row="1" Grid.Column="1" Text="{Binding Path=Description}"/>
      <TextBlock Grid.Row="2" Grid.Column="0" Text="Priority:"/>
      <TextBlock Grid.Row="2" Grid.Column="1" Text="{Binding Path=Priority}"/>
    </Grid>
  </Border>
  </DataTemplate>
  <!--ListBox-->
  <ListBox Width="400" Margin="10"
     ItemsSource="{Binding Source={StaticResource myTodoList}}"
     ItemTemplate="{StaticResource myTaskTemplate}" 
     HorizontalContentAlignment="Stretch"/>
```
### Data Triggery w DataTemplate:
```xml
<DataTemplate x:Key="myTaskTemplate">
<DataTemplate.Triggers> <!--Implementuje trigger-->
  <DataTrigger Binding="{Binding Path=TaskType}"> <!--Odnosi się do konkretnego typu w kodzie C#-->
    <DataTrigger.Value> <!--Reaguje na konkretna wartość -->
      <local:TaskType>Home</local:TaskType> <!--działa tylko jak Type=Home-->
    </DataTrigger.Value>
    <Setter TargetName="border" Property="BorderBrush" Value="Yellow"/>
  </DataTrigger>
</DataTemplate.Triggers>
</DataTemplate>
```
### Wybieranie między szablonami
XAML:
```xml
<DataTemplate x:Key="myTaskTemplate"> <!--Pierwszy DataTemplate-->
<!-- jakaś treść-->
</DataTemplate>
<DataTemplate x:Key="importantTaskTemplate"> <!--Drugi DataTemplate-->
<!-- jakaś treść-->
</DataTemplate>
```
Kod w C#:
```cs
using System.Windows;
using System.Windows.Controls;

namespace SDKSample
{
    public class TaskListDataTemplateSelector : DataTemplateSelector //Potrzebne jesli chcemy wybrac DataTemplate
    {
        public override DataTemplate
            SelectTemplate(object item, DependencyObject container) //funkcja wbudowana do wybieranie DataTemplate
        {
            FrameworkElement element = container as FrameworkElement; //Zamiana container na FrameworkElement

            if (element != null && item != null && item is Task) //chroni przed błędami
            {
                Task taskitem = item as Task; 

                if (taskitem.Priority == 1)
                    return
                        element.FindResource("importantTaskTemplate") as DataTemplate;
                else
                    return
                        element.FindResource("myTaskTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
```

# ControlTemplate
ControlTemplate w WPF określa jak wygląda kontrolka od środka, czyli jej wizualną strukturę (np. Button, TextBox).
Pozwala całkowicie zmienić wygląd kontrolki, bez zmiany jej zachowania i logiki.
Używa się go do tworzenia własnych skórek i stylów kontrolek.
## Kod
### Podstawowa struktura ControlTemplate:
```xml
<Style TargetType="Button"> 
  <Setter Property="OverridesDefaultStyle" Value="True"/>
  <Setter Property="Template"> <!-- Bez tego nie zadziała -->
    <Setter.Value>
      <ControlTemplate TargetType="Button"> <!--Element jaki chcemy stylować-->
        <Grid>
          <Ellipse Fill="{TemplateBinding Background}"/> <!--Lączymy rozmiar Eclipse z zawartością-->
          <ContentPresenter HorizontalAlignment="Center"
                            VerticalAlignment="Center"/> <!--Do ustawiania gdzie ma sie znalezc zawartosc-->
        </Grid>
      </ControlTemplate>
    </Setter.Value>
  </Setter>
</Style>
```
### Atrybuty które można zmienić w ControlTemplate:
```xml
  <Setter Property="SnapsToDevicePixels"
          Value="true" /> <!--Cały rozmiar ekranu -->
  <Setter Property="FocusVisualStyle"
          Value="{StaticResource ButtonFocusVisual}" /> <!--Wygląd elementu gdy jest na niego focus-->
  <Setter Property="MinHeight"
          Value="23" />
  <Setter Property="MinWidth"
          Value="75" />
```
# System nawigacji
Przechodzenie między widokami w WPF
## Kod
MainWindow.xaml
```xml
<Window>
  <Window.DataContext> <!--Strona główna-->
    <MainViewModel />
  </Window.DataContext>

  <Window.Resources>
    <DataTemplate DataType="{x:Type WelcomePageviewModel}"> <!--1 strona itd.-->
      <WelcomePage />
    </DataTemplate>

    <DataTemplate DataType="{x:Type LoginPageviewModel}">
      <LoginPage />
    </DataTemplate>

    <DataTemplate DataType="{x:Type CalculatorPageviewModel}">
      <CalculatorPage />
    </DataTemplate>
  </Window.Resources>

  <StackPanel> <!-- do wyboru stron-->
    <ListBox ItemsSource="{Binding NavigationItems}">
      <ListBox.ItemsPanel>
        <ItemsPanelTemplate>
          <VirtualizingStackPanel Orientation="Horizontal" />
        </ItemsPanelTemplate>
      </ListBox.ItemsPanel>

      <ListBox.ItemTemplate> 
        <DataTemplate> 
          <Button Content="{Binding PageTitle}" 
                  Command="{Binding NavigateCommand}" 
                  CommandParameter="{Binding PageIndex}" />
        </DataTemplate> 
      </ListBox.ItemTemplate> 
    </ListBox>
    <ContentControl Content="{Binding SelectedPage}" />
  <StackPanel>
</Window>

```
MainViewModel.cs
```cs
class MainViewModel
{
  public ICommand SelectPageCommand => new RelayCommand(SelectPage);  //wiąże polecenia w XAML
  public ObservableCollection<NavigationItem> NavigationItems { get; }   
  private Dictionary<int, IPage> Pages { get; }

  private IPage selectedPage;   
  public IPage SelectedPage
  {
    get => this.selectedPage;
    set 
    { 
      this.selectedPage = value; 
      OnPropertyChanged();
    }
  }

  public MainViewModel()
  {
    this.NavigationItems = new ObservableCollection<NavigationItem> //ilosc stron
    {
      new NavigationItem("Home", 0, this.SelectPageCommand),
      new NavigationItem("Login", 1, this.SelectPageCommand)
    };
     
    this.Pages = new Dictionary<int, IPage>
    {
      { 0, new WelcomePageViewModel() },
      { 1, new LoginPageViewModel() }
    };

    this.SelectedPage = this.Pages.First().Value; 
  }

  public void SelectPage(object param) //do wyboru strony
  {
    if (param is int pageIndex 
      && this.Pages.TryGetValue(pageIndex, out IPage selectedPage))
    {
      this.SelectedPage = selectedPage;
    }
  }

  public void AddPage() //dodaje nową stronę
  {
    int newPageIndex = this.Pages.Count;

    IPage calculatorPageModel = new CalculatotPageViewModel();
    this.Pages.Add(newPageIndex, calculatorPageModel);

    var navigationItem = new NavigationItem("Calculator", newPageIndex, this.SelectPageCommand);
    this.NavigationItems.Add(navigationItem);
  }

  public event PropertyChangedEventHandler PropertyChanged; //jak sie zmieni wartość to wywołuje OnPropertyChanged()
  protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
    => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
```