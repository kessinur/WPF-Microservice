   M S B A M L   `   `   `  ����F  BBootcampWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BootcampWPFBootcampWPF  5   	       BootcampWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BootcampWPF     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      � .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��309��6D   $��10,0,0,0q�6Q   $	��Top=�6c   $	��507��6{   .@�5      �� $��Manage Supplier��6   .��5      � ���	#FFE5E5E5$��
0,-11,0,11q�6.    � ColumnDefinitions 5      �� 5      $	��75* �6+   �� 5      $	��68* �6+   �� 5      $	��13* �6+   �� 5      $
��191* �6+   �� 5      $
��154* �6+   .+�5      �� -   5         ��Name$ SaveButton1��5      $��3��62   $��Button��6F   $��1��6W   $
��Left=�6g   $��	24,63,0,0q�6�   $	��Top=�6�   $��75��6�   6�   �� 5      -   5        $ 
SaveButton��5      $��Insert��61   $��1��6B   $
��Left=�6R   $��
24,136,0,0q�6m   $	��Top=�6�   $��75��6�   $��3��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ SupplierDataGrid��5         
IsReadOnly . $
��Left=�6K   $��	0,161,0,0q�6f      AutoGenerateColumns .  $	��Top=�6�   $��5��6�   $	��501��6�   $	��120��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� 
 �� Path$
 Id�6[     5      $
 Name��61   	 6?   �� $

 Name�6_     5      $ 	Join Date��61   	 6D   �� $
 JoinDate�6h   5      5      5      �� 5       $��Manage Item��6   .��5!      � ���	#FFE5E5E56   5"      5#      �� 5$   
   -   5         ��Name$ label��5$      $
��Name��6   $
��Left=�6.   $	��Top=�6I   $��
19,118,0,0q�6a   �� 5%   
   -   5         ��Name$ NameTextBox1��5%      $
��Left=�6(   $��23��6C    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��	79,41,0,0q�6�   �� 5&   
   -   5        $ ResultTextBox��5&      $
��Left=�6)   $��23��6D   $
 Wrap=�6P   $	��Top=�6d   $	��120��6|   $��
292,41,0,0q�6�   �� 5'   
   -	   5        $ NameTextBox��5'      $
��Left=�6'   $��23��6r   $
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $	��295��6�   $��
79,118,0,0q�6�   6�   �� 5(   
   -
   5        $ CountTextBox��5(      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $�� ��6c   $	��Top=�6k   $��35��6�   $��387,118,0,0q�6�   6�   �� 5)   
   -   5         ��Name$ SupplierComboBox��5)       �� DisplayMemberPath$
 Name��6V    �� SelectedValuePath$ Id��6o   $	��Top=�6�   $��203,150,13,0q�6�   ��6-   �� $
 getSupplier�6�   5*      5+      