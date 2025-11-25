# How to Customize ScrollBar and WPF GridControl Border?

This example demonstrates how to customize the scrollbar and [WPF GridControl](https://www.syncfusion.com/wpf-controls/excel-like-grid) border.

To change the border style of `GridControl`, add grid control inside the Border element and change the border style like `CornerRadius`, `BorderThickness`, etc.

To customize the appearance of scrollbar thumb and scrollbar buttons, create the custom  control templates for vertical and horizontal scrollbar and modify the Template property value with custom control templates. Please refer the sample demo.

``` xml
<!--Code for ScrollBar resource-->
<Grid>
    <Border BorderBrush="Black" CornerRadius="5" BorderThickness="1">  
        <ScrollViewer HorizontalScrollBarVisibility="Auto"
                      VerticalScrollBarVisibility="Auto" CanContentScroll="True">   
            <syncfusion:GridControl x:Name="grid"/>
        </ScrollViewer>
    </Border>
</Grid>
```

![GridControl with customized scrollbar](GridcontrolWithCustomizedScrollBar.png)