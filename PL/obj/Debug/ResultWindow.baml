   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   = 9BL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BO;assembly=BLBO 5   	       PL.ResultWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   +BOclr-namespace:BO;assembly=BL     5   	     � Title$  ResultWindow��5	   	   $��844.048��6   $��1218.605��6/   .��5      �  � RowDefinitions 5   
   �� 5      $
��277* �6   �� 5      $
��251* �6   �� 5      $
��286* �6   .+�5   
   �� $��Result��6   $
��Left=�6!   $��	52,21,0,0q�6<   $	��Top=�6O   $��43��6g   $	��253��6s   ���	#FF0EA974$
��Bold"�6�   $��20(�6�   �� 5   
   -   5         ��Name$ 
seqtextBox��5      $��Stretch=�6*   $	��201��6H   $��
10,66,10,0q�6U   $	��Top=�6j    �� 
IsReadOnly . $��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ UniqueDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��113,11.2,113,13q�6~      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $��16(�6�      
IsReadOnly . 
��� ���$��1��6�   ��6f   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        sequenceColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Sequence��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6l      MinWidth$	 100Q�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
Sequence+6�     5      -   5        firstIndexColumn��$
 First Index��5   ^   $ SizeToHeader 6s   $	 100Q�6�    6?   �� *
FirstIndex+6�     5      -   5        lastIndexColumn��$
 
Last Index��5   \   $ SizeToHeader 6p   $	 100Q�6�    6>   �� *	LastIndex+6�     5      -   5        proteinGIColumn��$
 
Protein GI��5   \   $ SizeToHeader 6p   $	 100Q�6�    6>   �� *	ProteinGI+6�     5      -   5        proteinNameColumn��$
 Protein Name��5   `   $ SizeToHeader 6v   $	 100Q�6�    6@   �� *ProteinName+6�   5        5   
   -   5        $ SemiUniqueDataGrid��5       .   . $��113,16,113,40.4q�6�   $ VisibleWhenSelected=�6�   $��16(�6�    . 
����� �$��2��6  ��6j   �� 	 5        5       -	   5        sequenceColumn1��$
 Sequence��5    [   $	 100Q�6m   $ SizeToHeader 6|    6>   �� *
Sequence+6|     5!      -
   5        firstIndexColumn1��$
 First Index��5!   _   $ SizeToHeader 6t   $	 100Q�6�    6@   �� *
FirstIndex+6�     5"      -   5        lastIndexColumn1��$
 
Last Index��5"   ]   $ SizeToHeader 6q   $	 100Q�6�    6?   �� *	LastIndex+6�     5#      -   5        proteinGIColumn1��$
 
Protein GI��5#   ]   $ SizeToHeader 6q   $	 100Q�6�    6?   �� *	ProteinGI+6�     5$      -   5        proteinNameColumn1��$
 Protein Name��5$   a   $ SizeToHeader 6x   $	 100Q�6�      FontSize$ 16Q�6�    6A   �� *ProteinName+6�   5'      5)      5*      