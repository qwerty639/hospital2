   M S B A M L   `   `   `  ����C  ?HOSPITAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:HOSPITAL.Views.Pages.GridPagesHOSPITAL.Views.Pages.GridPages  5      4    .HOSPITAL.Views.Pages.GridPages.TherapyGridPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:HOSPITAL.Views.Pages.GridPages     5      -   5          N� Title$  TherapyGridPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $��* �6   �� 5      $
��0.4* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Center=�5      $��Center=�5      .+�5      �� -   5         ��Name$ btnAdd��5      $��Добавить��5      $��30��5      $	��150��5      $��15(�5      6'   5!      5"      � 5$   
   $��1��6   .+�5%      &   System.Windows.Controls.DataGrid  -   5          Name$ dbView��5%         AutoGenerateColumns .     
IsReadOnly .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5(      $��10q�5)         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Id+  5,      $	 ФИО пациента��6)   
 6?   �� *PATIENT.Fullname+  5-      $	 ФИО врача��6)   
 6<   �� *DOCTOR.Doctorname+  5.      $	 Диагноз��6)   
 6:   �� *
Diagnose+  5/      $1	 +Амб.лечение необходимо?��6)   
 6J   �� *
Ambulatory+  50      $<	 6Срок потери трудоспособности��6)   
 6O   �� *
Disability+  51      $!	 Начало лечения��6)   
 6A   �� *Begintherapy+53      54      � 56   
   $��2��6   .+�57      ��  �� Orientation$ 
Horizontal=�6   $��Center=�58      .+�59      �� -   5        $ btnMenu��59      $��Главное меню��5:      $��30��5;      $	��150��5<      6)   �� 5=      -   5        $ 	btnDelete��5=      $��Удалить��5>      $��30��5?      $	��150��5@      $��10q�5A      6%   �� 5B      -   5        $ btnEdit��5B      $ ��Редактировать��5C      $��30��5D      $	��150��5E      6%   5F      5G      5H      5I      