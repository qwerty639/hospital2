   M S B A M L   `   `   `  ����C  ?HOSPITAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:HOSPITAL.Views.Pages.GridPagesHOSPITAL.Views.Pages.GridPages  5      3    -HOSPITAL.Views.Pages.GridPages.DoctorGridPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:HOSPITAL.Views.Pages.GridPages     5      -   5          N� Title$  DoctorGridPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $��* �6   �� 5      $
��0.4* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Center=�5      $��Center=�5      .+�5      �� -   5         ��Name$ btnAdd��5      $��Добавить��5      $��30��5      $	��150��5      $��15(�5      6'   5!      5"      � 5$   
   $��1��6   .+�5%      &   System.Windows.Controls.DataGrid  -   5          Name$ dbView��5%         AutoGenerateColumns .     
IsReadOnly .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5(      $��10q�5)         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Id+  5,      $	 Имя врача��6)   
 6<   �� *
Doctorname+  5-      $	 Должность��6)   
 6<   �� *Post+  5.      $	 Квалификация��6)   
 6?   �� *SKILLTABLE.Skill+  5/      $ 	 Специализация��6)   
 6@   �� *$"SPECIALIZATIONTABLE.Specialization+51      52      � 54   
   $��2��6   .+�55      ��  �� Orientation$ 
Horizontal=�6   $��Center=�56      .+�57      �� -   5        $ btnMenu��57      $��Главное меню��58      $��30��59      $	��150��5:      6)   �� 5;      -   5        $ 	btnDelete��5;      $��Удалить��5<      $��30��5=      $	��150��5>      $��10q�5?      6%   �� 5@      -   5        $ btnEdit��5@      $ ��Редактировать��5A      $��30��5B      $	��150��5C      6%   5D      5E      5F      5G      