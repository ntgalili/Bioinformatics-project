   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   = 9BL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BO;assembly=BLBO 5   	       PL.VirtualSequenceWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   +BOclr-namespace:BO;assembly=BL     5   	     � Title$  VirtualSequenceWindow��5	   	   $��505.8��6'   $��826.4��66   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ virtualSequenceDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�64   $��80,136,69,67.6q�6c      EnableRowVirtualization .    AutoGenerateColumns .  $��16(�6
  $
��Bold"�6  ���	#FF0EA974   HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . ��6{   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        sequenceColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 5   =   
   Header$
 Sequence��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *
Sequence+  5      -   5        countColumn��$	 * 5   :   $
 count��6D    6S   �� *count+4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$
 show��6%   -   5        $
��show��5   3    � ToolTip$ click show the locations ��6C   6g   5      5      5      �� 5   
   -   5         ��Name$ cutComboBox��5      $
��Left=�6(   $��
396,57,0,0q�6C   $	��Top=�6W   $	��221��6o   $��37��6{   $��16(�6�   ���	#FF0EA974 �� SelectedItem 6�   �� *CuttingType+6�   �� 5   
   $&�� How do you want to make the cut?��6   $
��Left=�6;   $��	80,60,0,0q�6V   $	��Top=�6i   $��34��6�   $	��297��6�   $
��Bold"�6�   ���	#FFFF80006�   5      5      