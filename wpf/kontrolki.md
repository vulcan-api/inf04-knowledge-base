## GroupBox 
> GroupBox to WPFowy ekwiwalent znacznika ```<Fieldset> ``` Jest to obramówka grupująca powiązane ze sobą pola formularza

Przykładowy 
![GroupBox](./obrazki/groupbox.png)

Kilka uwag:

+ Nagłówek GroupBoxa to ``` <GroupBox Header = "..."> ```
+ Wewnątrz GroupBoxa może znajdować się tylko jeden element - Dowolny, ale sugerowany jest np. `<StackPanel>`

Przykładowy kod 

```xml 
<GroupBox Header="Login Credentials" Margin="10">
    <StackPanel Margin="5">
        <Label Content="Username:"/>
        <TextBox/>
        <Label Content="Password:"/>
        <PasswordBox/>
    </StackPanel>
</GroupBox>

``` 