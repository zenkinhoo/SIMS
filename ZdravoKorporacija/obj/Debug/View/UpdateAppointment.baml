   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   $    Bolnica.View.UpdateAppointment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ 
ToolWindow=�5
   
    � 
ResizeMode$ NoResize=�5   	    � Title$ UpdateAppointment��5   	   $	��550��6#   $	��400��60   $��Segoe UI Black)�6<   ���	#FFBBB6B6 � 	Resources 5         MyWaterMarkStyle �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 ��Name
 � Tag �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� ���	#FFFBF7F7���	#FF7D86836<   �� 5      $	 PART_ContentHost��6+   $��5,0,0,0q�6E   $��Center=�6V   �� 5      $
 WaterMarkLabel��65   $��5,0,0,0q�6$   #��z 6M   $��Center=�6m   $y�	Collapsed=�5   !   ���#5d5b5b$��Segoe UI Black)�6M   5       5      ]� 5       5   "   �� 5   &    � ��$  ��6@   ./�5   "   �� $ WaterMarkLabel��6?    � y�$ Visible=�6[   5      P� 5       � {� .  . �5    "   ��  � ��
 �iii�6?   5!      5#      5%      5&      5'      .��5(      � .+�5)   
   &   System.Windows.Controls.Calendar  -   5          Name$ DatePick��5)      $��10,10,208,318q�6%   �� 5*   
   $��Select Priority��6   $��Center=�6,   $��Center=�6K   $��16(�6f   $��Center=�6t   $��Segoe UI Black)�6�   $��30��6�   $��198,10,74,482q�6�   $	��122��6�   	� 5+   
   -   5         	�Name$ radioDoctor��5+      $��Doctor��6+   $��14(�6<   $��Center=�6J   $��Center=�6e   $��25��6�   $��201,40,53,457q�6�   	� 5,   
   -   5        $ 	radioTime��5,      $
��Time��6)   $��14(�68   $��Center=�6F   $��Center=�6a   $��25��6�   $��203,70,51,427q�6�   �� 5-   
   -   5        $��Find Free Terms��5-      $��15(�6,   $��Segoe UI Black)�6:   $��3q�6V   ���	#FF4D4B4B$��201,286,31,174q�6�    � ToolTip 5.      �� 5/      .+�50      �� $
��Bold"�6    $��14(�62   $��0,0,0,5q�6@   Click the button6c   �� 51      :8Click here see doctor's schedule for selected time range53      �� 54      
�������$��0,1,0,0q�62   $	��0,8q�6L   � 55      .+�56      �� $��/Images/bell.png��6    $��0,0,0,0q�6:   $��15��6K   $��20��6W   �� 57      $��Italic$�6$   Showing doctor's free terms6T   58      59      5;      �� 5<   
   -   5         ��Name$ ListFreeTerms��5<      $��15(�6*   $��Center=�68   ���	#FFDDDDDD$��3q�6q   ���	#FF4D4B4B$��Segoe UI Black)�6�   $��Center=�6�   $��10,190,208,82q�6�   �� 5=   
   -   5        $��Close��5=      $��16(�6!   $��Segoe UI Black)�6/   $��3q�6K   ���	#FF4D4B4B$��10,450,208,10q�6�   �� 5>   
   -   5        $��Update��5>      $��16(�6"   $��Segoe UI Black)�60   $��3q�6L   ���	#FF4D4B4B$��201,450,31,10q�6�   �� 5?   
   $��Duration in hours:��6   $��Center=�6.   $��Center=�6M   $��16(�6h   $��Center=�6v   $��Segoe UI Black)�6�   $��30��6�   $��198,353,34,139q�6�   $	��162��6�   �� 5@   
   -	   5         ��Name$ Duration��5@   F   #��[  6   $	 0-1��6<   $��82��6X   $��Segoe UI Black)�6d   ���	#FFFBF7F7$��16(�6�   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��Center=�6�   $��Center=�6  $��205,394,107,82q�66  �� 5A   
   $��
Start Time��6   $��Center=�6&   $��Center=�6E   $��16(�6`   $��Center=�6n   $��Segoe UI Black)�6�   $��30��6�   $��201,95,87,397q�6�   $	��106��6�   �� 5B   
   $��End Time��6   $��Center=�6$   $��Center=�6C   $��16(�6^   $��Center=�6l   $��Segoe UI Black)�6�   $��30��6�   $��198,190,90,302q�6�   $	��106��6�   �� 5C   
   -
   5        $ tb_startTime��5C   H   #��[  6   $ hh:mm��6<   $��84��6^   $��Segoe UI Black)�6j   ���	#FFFBF7F7$��16(�6�   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��Center=�6�   $��Center=�6  $��203,130,107,347q�6<  �� 5D   
   -   5        $ 
tb_endTime��5D   H   #��[  6   $ hh:mm��6<   $��86��6\   $��Segoe UI Black)�6h   ���	#FFFBF7F7$��16(�6�   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��Center=�6�   $��Center=�6  $��201,225,107,250q�6:  5F      5G      