   M S B A M L   `   `   `  ����O  KSkillboxHomework10_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SkillboxHomework10_1SkillboxHomework10_1  5   	   %    SkillboxHomework10_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SkillboxHomework10_1     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
mainWindow��5   	      MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ 
MainWindow��5      $	��450��6   $	��800��6+    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext$ 
MainWindow��5   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgClientsList��5      $��10,10,10,130q�6)      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 180 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ��  �� Path$ LastName�6j     5      $ Имя��6%   	 . $	
 120 6b    62   �� $
 Name�6b     5      $ Отчество��6%   	 . $	
 120 6j    67   �� $ SurName�6j     5      $! Номер телефона��6%   	 . $	
 150 6t    6=   �� $ PhoneNumber�6t     5      -   5        passportColumn��$' !Паспортные данные��5   =   	 . $	
 150 6�    6X   �� $ Passport�6�   5      �� 5    
   -   5        $��	btnChange��5       $#��Изменить данные��6"   $
��Left=�6<   $��	30,0,0,40q�6W   $	��160��6j   $��30��6�   $��Bottom=�6�   �� 5!   
   -   5        $��btnAdd��5!      $%��Добавить клиента��6   $
��Left=�6:   $��
220,0,0,40q�6U   $	��160��6i   $��30��6�   $��Bottom=�6�   �� 5"   
   -   5        $��	btnDelete��5"      $#��Удалить клиента��6"   $��Right=�6<   $��
0,0,220,40q�6X   $	��160��6l   $��30��6�   $��Bottom=�6�   �� 5#   
   -   5        $$��Сохранить в файл��5#      $��	0,0,30,40q�6,   $��Right=�6T   $	��160��6p   $��30��6|   $��Bottom=�6�   �� 5$   
   -   5        $��tbInfo��5$      $��30,304,30,90q�6"   $
��Wrap=�68   ��6L   �� $
 info�5&      5(      