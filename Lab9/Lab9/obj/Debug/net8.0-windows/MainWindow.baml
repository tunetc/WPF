   M S B A M L   `   `   `  ����?  ;Lab9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab9Lab9  5   	       Lab9.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab9     5   	   -   5          � Title$  Text Editor (v 1.0)��5   	   $	��350��6%   $	��520��62    � WindowStartupLocation$ CenterScreen=�6>    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Close��5      5        5   
   -   5        $ ApplicationCommands.New��5      5        5   
   -   5        $ ApplicationCommands.Open��5      5        5   
   -   5        $ ApplicationCommands.Save��5      5   3     5   
   -   5        $  ApplicationCommands.SaveAs��5      5      .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� $
��_New��6    m� Command$ ApplicationCommands.New��6)   m� 5      $��_Open��6   $ ApplicationCommands.Open��6*   m� 5      $��_Save��6   $ ApplicationCommands.Save��6*   m� 5      $��
Save as...��6   $  ApplicationCommands.SaveAs��6/   �� 5      m� 5      $��E_xit��6    m� InputGestureText$ Alt+F4��6*   $ ApplicationCommands.Close��6D   5      5       �� 5!   
   -   5         ��Name$ textBox1��5!       �� AcceptsReturn$
 True��6$   " �� VerticalScrollBarVisibility$
 Auto=�69   $	 �� HorizontalScrollBarVisibility$
	 Auto=�5"      
 �� 
AcceptsTab$

 True��67   5#      5$      5%      