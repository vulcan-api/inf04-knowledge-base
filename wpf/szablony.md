# Style, Binding i szablony (ControlTemplate, DataTemplate)

# Style
```xml
<Window.Resources>
    <!-- Inne zasoby okna mogłyby tu być -->

    <!-- Styl, który wpływa na wszystkie TextBlocki w oknie -->
    <Style TargetType="TextBlock">
        <Setter Property="HorizontalAlignment" Value="Center" /> <!-- Wyśrodkowanie tekstu -->
        <Setter Property="FontFamily" Value="Comic Sans MS"/>      <!-- Czcionka -->
        <Setter Property="FontSize" Value="14"/>                  <!-- Standardowy rozmiar tekstu -->
    </Style>
    
    <!-- Styl dziedziczący po powyższym, przeznaczony do nagłówków -->
    <Style BasedOn="{StaticResource {x:Type TextBlock}}"      
           TargetType="TextBlock"
           x:Key="TitleText"> <!-- Nadajemy nazwę stylu, aby można go było użyć selektywnie -->
        
        <Setter Property="FontSize" Value="26"/><!-- Większy rozmiar tekstu dla nagłówków -->
        
        <Setter Property="Foreground">                        <!-- Kolor tekstu -->
            <Setter.Value>
                <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1"> <!-- Gradient pionowy -->
                    <LinearGradientBrush.GradientStops>
                        <GradientStop Offset="0.0" Color="#90DDDD" />  <!-- Górny kolor gradientu -->
                        <GradientStop Offset="1.0" Color="#5BFFFF" />  <!-- Dolny kolor gradientu -->
                    </LinearGradientBrush.GradientStops>
                </LinearGradientBrush>
            </Setter.Value>
        </Setter>
    </Style>
</Window.Resources>
```
# Binding
## Co to?
Binding w WPF to mechanizm, który wiąże dane z kodu (ViewModel/Model) z interfejsem użytkownika (View). Dzięki bindingowi zmiany w danych automatycznie aktualizują widok, a zmiany w widoku mogą automatycznie trafiać do danych, bez pisania ręcznego kodu do synchronizacji.
Wyróżniamy 2 typu Binding-ów:
- OneWay (tylko ze źródła do widoku)
- TwoWay (w obu kierunkach)
### Przykłąd z Bindingiem:
```xml
<Window x:Class="BindingExample.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Binding Example" Height="200" Width="300">
    
<Window.DataContext>
 <local:PersonViewModel /><!-- Ustawiamy ViewModel jako DataContext/domyślnie plik .cs danego xml -->
    </Window.DataContext>

    <StackPanel Margin="20">
        <TextBox Text="{Binding Name, Mode=TwoWay}" /> <!-- TwoWay Binding -->
        <TextBlock Text="{Binding Name}" Margin="0,10,0,0"/> <!-- Wyświetla aktualną wartość Name -->
    </StackPanel>
</Window>
```

# Data Template

## Co to?
Pudełko na dane, które umożliwia ich wyświetlenie w XML np. dla ListBoxa
## Kod
### Podstawowy kod (z bindingiem)
```xml
<DataTemplate>
    <!-- Szablon określa jak ma wyglądać jeden element danych -->
    <TextBlock Text="{Binding Name}" />
    <!-- {Binding Name} oznacza: weź wartość z właściwości 'Name' obiektu
         i wstaw jako tekst w tym miejscu -->
</DataTemplate>
```
### Przykład z ListBox
```xml
<ListBox Width="400" Margin="10" ItemsSource="{Binding Source={StaticResource myTodoList}}">
   <ListBox.ItemTemplate><!-- Mówimy ListBoxowi: jak ma wyglądać *pojedynczy element* listy -->
     <DataTemplate>
       <StackPanel>
         <TextBlock Text="{Binding Path=TaskName}" /> 
         <!-- Wyświetlamy nazwę zadania (pobrane z właściwości TaskName z obiektu) -->
         <TextBlock Text="{Binding Path=Description}"/>
         <TextBlock Text="{Binding Path=Priority}"/>
       </StackPanel>
     </DataTemplate>
   </ListBox.ItemTemplate>
 </ListBox>
```
Klasa z przykładu:
```c#
public class Task 
{
    public string TaskName { get; set; }
    public string Description { get; set; }
    public string Priority { get; set; }
}
//Lista z przykładu:
public List<Task> myTodoList = new()
{
    new Task { TaskName="Zakupy", Description="Chleb, mleko", Priority="Wysoki" },
    new Task { TaskName="Trening", Description="Siłownia 18:00", Priority="Średni" }
};


```
### Przykład z Window.Resource
```xml
<Window.Resources>                <!-- Tu trzymamy zasoby okna: style, szablony, dane, itd. -->
    
    <DataTemplate x:Key="myTaskTemplate"> <!-- Tworzymy DataTemplate z własnym kluczem (x:Key)-->
        <StackPanel>                              <!-- Układ pionowy – elementy będą pod sobą -->
            <TextBlock Text="{Binding Path=TaskName}" />     <!-- Wyświetli nazwę zadania -->
            <TextBlock Text="{Binding Path=Description}"/>   <!-- Opis zadania -->
            <TextBlock Text="{Binding Path=Priority}"/>      <!-- Priorytet (np. wysoki/niski) -->
        </StackPanel>
    </DataTemplate>

</Window.Resources>

```
### Zamiast x:Key można też dać
```xml
<DataTemplate DataType="{x:Type local:Task}"> <!--X:Type local:nazwa_modelu w tym przypadku Task -->
  <StackPanel>
    <TextBlock Text="{Binding Path=TaskName}" />
    <TextBlock Text="{Binding Path=Description}"/>
    <TextBlock Text="{Binding Path=Priority}"/>
  </StackPanel>
</DataTemplate>
```
Później w XAML:
```xml
<ListBox Width="400" Margin="10" ItemsSource="{Binding Source={StaticResource myTodoList}}"    
         ItemTemplate="{StaticResource myTaskTemplate}"/> 
```
### Przykład z customowym DataTemplate
```xml
<DataTemplate x:Key="myTaskTemplate">                    <!-- Szablon wyglądu jednego elementu ListBoxa -->
  <Border Name="border" BorderBrush="Aqua" BorderThickness="1" 
          Padding="5" Margin="5">                        <!-- Obramowanie i odstępy, żeby ładniej wyglądało -->
    
    <Grid>                                                <!-- Układ siatki (kolumny + wiersze) -->
      <Grid.RowDefinitions>                              <!-- Tworzymy 3 wiersze -->
        <RowDefinition/>
        <RowDefinition/>
        <RowDefinition/>
      </Grid.RowDefinitions>

      <Grid.ColumnDefinitions>                           <!-- Tworzymy 2 kolumny -->
        <ColumnDefinition />
        <ColumnDefinition />
      </Grid.ColumnDefinitions>

      <!-- Etykieta + wartość TaskName -->
      <TextBlock Grid.Row="0" Grid.Column="0" Text="Task Name:"/>           <!-- Tekst opisowy -->
      <TextBlock Grid.Row="0" Grid.Column="1" Text="{Binding TaskName}" />  <!-- Wartość z obiektu Task -->

      <!-- Etykieta + wartość Description -->
      <TextBlock Grid.Row="1" Grid.Column="0" Text="Description:"/>         <!-- Tekst opisowy -->
      <TextBlock Grid.Row="1" Grid.Column="1" Text="{Binding Description}"/> <!-- Dane z modelu -->

      <!-- Etykieta + wartość Priority -->
      <TextBlock Grid.Row="2" Grid.Column="0" Text="Priority:"/>            <!-- Tekst opisowy -->
      <TextBlock Grid.Row="2" Grid.Column="1" Text="{Binding Priority}"/>    <!-- Priorytet zadania -->
    </Grid>

  </Border>
</DataTemplate>
<!-- ListBox używa powyższego DataTemplate -->
<ListBox Width="400" Margin="10"
     ItemsSource="{Binding Source={StaticResource myTodoList}}"
     ItemTemplate="{StaticResource myTaskTemplate}"               
     HorizontalContentAlignment="Stretch"/>               <!-- Rozciąga element na szerokość -->
```
### Data Triggery w DataTemplate
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
#### DataTrigger
DataTrigger to mechanizm w XAML, który reaguje na wartość danych i zmienia wygląd elementu, gdy spełniony jest określony warunek.
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
    // Klasa pozwalająca wybrać różne DataTemplate w zależności od danych
    public class TaskListDataTemplateSelector : DataTemplateSelector // Dziedziczymy aby móc nadpisywać SelectTemplate
    {
        // Metoda decydująca, który DataTemplate ma zostać użyty dla danego elementu
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            // Próba zamiany kontenera na FrameworkElement,
            // potrzebne do wyszukiwania zasobów po nazwie (FindResource)
            FrameworkElement element = container as FrameworkElement;

            // Sprawdzamy czy element istnieje, czy item nie jest null
            // i czy przekazany obiekt jest typu Task — zapobiega błędom
            if (element != null && item != null && item is Task)
            {
                Task taskitem = item as Task; // Rzutowanie elementu listy na Task

                // Jeśli priorytet = 1 → wybierz template "importantTaskTemplate"
                if (taskitem.Priority == 1)
                    return element.FindResource("importantTaskTemplate") as DataTemplate;
                else
                    // W innym przypadku użyj standardowego
                    return element.FindResource("myTaskTemplate") as DataTemplate;
            }

            return null; // Jeśli coś poszło nie tak — nie zwracamy żadnego template
        }
    }
}

```

# ControlTemplate
ControlTemplate w WPF to szablon, który definiuje pełny wygląd i strukturę wizualną kontrolki (np. Button, TextBox, ListBox).
Pozwala całkowicie zmienić wygląd kontrolki bez ingerowania w jej logikę czy działanie.
Dzięki temu można tworzyć własne style, motywy lub „skórki” dla kontrolek, zachowując ich standardowe zachowanie i interakcje.
## Kod
### Podstawowa struktura ControlTemplate
```xml
<Style TargetType="Button"> 
  <!-- Styl dla wszystkich przycisków w tym oknie/aplikacji -->

  <Setter Property="OverridesDefaultStyle" Value="True"/>
  <!-- Wyłącza domyślny wygląd Buttona, aby nasz ControlTemplate mógł działać -->

  <Setter Property="Template"> <!-- Podpinamy własny szablon wyglądu -->
    <Setter.Value>
      <ControlTemplate TargetType="Button"> <!-- Definiujemy wygląd przycisku -->
        
        <Grid> <!-- Układ elementów w przycisku -->
          
          <Ellipse Fill="{TemplateBinding Background}"/> 
          <!-- Tworzy okrągły kształt przycisku.
               TemplateBinding pozwala połączyć właściwość Background Buttona z wypełnieniem Ellipse -->

          <ContentPresenter HorizontalAlignment="Center"
                            VerticalAlignment="Center"/> 
          <!-- Pokazuje zawartość Buttona (np. tekst) w środku elipsy -->
          
        </Grid>
        
      </ControlTemplate>
    </Setter.Value>
  </Setter>
</Style>

```
### Atrybuty które można zmienić w ControlTemplate
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
  <!-- Ustawiamy główny DataContext okna na nasz ViewModel -->
  <Window.DataContext> 
    <MainViewModel /> <!-- Główny ViewModel całej aplikacji -->
  </Window.DataContext>

  <!-- Zasoby okna, czyli szablony widoków dla konkretnych ViewModeli -->
  <Window.Resources>
    
    <!-- Jeśli ContentControl otrzyma WelcomePageviewModel → wyświetli WelcomePage -->
    <DataTemplate DataType="{x:Type WelcomePageviewModel}"> 
      <WelcomePage />
    </DataTemplate>

    <!-- Jeśli ContentControl otrzyma LoginPageviewModel → wyświetli LoginPage -->
    <DataTemplate DataType="{x:Type LoginPageviewModel}">
      <LoginPage />
    </DataTemplate>

    <!-- Jeśli ContentControl otrzyma CalculatorPageviewModel → wyświetli CalculatorPage -->
    <DataTemplate DataType="{x:Type CalculatorPageviewModel}">
      <CalculatorPage />
    </DataTemplate>

  </Window.Resources>

  <!-- Główna zawartość okna -->
  <StackPanel> <!-- Układ pionowy: najpierw lista stron, potem wybrana strona -->

    <!-- Lista przycisków do wyboru stron -->
    <ListBox ItemsSource="{Binding NavigationItems}"> <!-- Kolekcja elementów nawigacyjnych z ViewModel -->
      
      <!-- Układ elementów listy w poziomie -->
      <ListBox.ItemsPanel>
        <ItemsPanelTemplate>
          <VirtualizingStackPanel Orientation="Horizontal" /> <!-- Elementy ułożone obok siebie, optymalizacja wirtualizacji -->
        </ItemsPanelTemplate>
      </ListBox.ItemsPanel>

      <!-- Szablon wyglądu jednego elementu listy (przycisk) -->
      <ListBox.ItemTemplate> 
        <DataTemplate>
          <Button Content="{Binding PageTitle}"           <!-- Tekst przycisku = tytuł strony -->
                  Command="{Binding NavigateCommand}"     <!-- Komenda wykonywana po kliknięciu -->
                  CommandParameter="{Binding PageIndex}" /><!-- Argument komendy = indeks strony -->
        </DataTemplate> 
      </ListBox.ItemTemplate> 

    </ListBox>

    <!-- Wyświetlanie aktualnie wybranej strony -->
    <ContentControl Content="{Binding SelectedPage}" /> <!-- Automatycznie dobiera odpowiedni DataTemplate z Window.Resources -->

  </StackPanel>
</Window>

```
MainViewModel.cs
```cs
class MainViewModel : INotifyPropertyChanged
{
    // Komenda wywoływana przy zmianie strony (wiązana w XAML)
    public ICommand SelectPageCommand => new RelayCommand(SelectPage);  

    // Kolekcja przycisków nawigacyjnych (dla ListBox w XAML)
    public ObservableCollection<NavigationItem> NavigationItems { get; }   

    // Słownik wszystkich stron (Index -> ViewModel strony)
    private Dictionary<int, IPage> Pages { get; }

    // Przechowuje aktualnie wybraną stronę
    private IPage selectedPage; 
    public IPage SelectedPage
    { 
        get => this.selectedPage;
        set 
        { 
            this.selectedPage = value; 
            OnPropertyChanged(); // Powiadamiamy widok, że SelectedPage się zmieniło
        }
    }

    // Konstruktor ViewModelu
    public MainViewModel()
    {
        // Tworzymy przyciski nawigacyjne
        this.NavigationItems = new ObservableCollection<NavigationItem>
        {
            new NavigationItem("Home", 0, this.SelectPageCommand),
            new NavigationItem("Login", 1, this.SelectPageCommand)
        };
         
        // Tworzymy słownik stron (indeks -> ViewModel strony)
        this.Pages = new Dictionary<int, IPage>
        {
            { 0, new WelcomePageViewModel() },
            { 1, new LoginPageViewModel() }
        };

        // Domyślnie wyświetlamy pierwszą stronę
        this.SelectedPage = this.Pages.First().Value; 
    }

    // Metoda wywoływana przez komendę SelectPageCommand
    public void SelectPage(object param)
    {
        // Sprawdza czy parametr jest indeksem strony i czy taka strona istnieje
        if (param is int pageIndex && this.Pages.TryGetValue(pageIndex, out IPage selectedPage))
        {
            // Ustawia wybraną stronę → ContentControl w XAML zaktualizuje widok
            this.SelectedPage = selectedPage;
        }
    }

    // Dodaje nową stronę do aplikacji
    public void AddPage()
    {
        int newPageIndex = this.Pages.Count; // Kolejny indeks

        // Tworzymy nowy ViewModel strony (np. kalkulator)
        IPage calculatorPageModel = new CalculatorPageViewModel(); 
        this.Pages.Add(newPageIndex, calculatorPageModel);

        // Dodajemy nowy element do kolekcji nawigacji, żeby przycisk pojawił się w ListBoxie
        var navigationItem = new NavigationItem("Calculator", newPageIndex, this.SelectPageCommand); 
        this.NavigationItems.Add(navigationItem);
    }

    // Właściwości powiadamiające widok o zmianach
    public event PropertyChangedEventHandler PropertyChanged; 
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

```