   M S B A M L   `   `   `  ����@  <INDZ5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:INDZ5INDZ5  5   	       INDZ5.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:INDZ5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� $��0��6   .@�5      m� $��_File��6   .@�5      m� -   5        $��_Open...��5      6-   m� 5      -   5        $��_Save��5      6*   �� 5      m� 5      -   5        $��E_xit��5      6*   5      5      �� 5   
   -   5         ��Name$ InputTextBox��5      $��1��6(    �� AcceptsReturn$
 True��65   " �� VerticalScrollBarVisibility$
 Auto=�6J   $ �� HorizontalScrollBarVisibility$
 Auto=�6m   $��10q�6�   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5      �� -   5         ��Name$ ConversionComboBox��5      $	��120��63   .@�5      �� $��10→2��6   �� 5      $��2→10��6   �� 5      $��10→16��6   �� 5      $��16→10��6   �� 5      $��2→16��6   �� 5      $��16→2��6   5       �� 5!      -   5         ��Name$ ConvertButton��5!      $��Convert��6,   $��75��6>   $��10,0,0,0q�6I   6[   5"      5#      5$      