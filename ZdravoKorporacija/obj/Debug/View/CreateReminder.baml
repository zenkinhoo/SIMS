   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.ValidationBolnica.View.Validation  5      +clr-namespace:Bolnica.ViewBolnica.View  5   	   !    Bolnica.View.CreateReminder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   6util%clr-namespace:Bolnica.View.Validation     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStyle$  
ToolWindow=�5	       � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � Title$ CreateReminder��5   	   $	��450��6    $	��420��6-   $��Segoe UI Black)�69   ���	#FFBBB6B6 � 	Resources 5         MyWaterMarkStyle �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 ��Name
 � Tag �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� ���	#FFFBF7F7$��3q�6=   ���	#FF4D4B4B6R   �� 5      $	 PART_ContentHost��6+   $��5,0,0,0q�6E   $��Center=�6V   �� 5      $
 WaterMarkLabel��65   $��5,0,0,0q�6$   #��z 6M   $��Center=�6m   $y�	Collapsed=�5       ���#5d5b5b$��Segoe UI Black)�6L   5       5      ]� 5       5   "   �� 5   &    � ��$  ��6@   ./�5   "   �� $ WaterMarkLabel��6?    � y�$ Visible=�6[   5      P� 5       � {� .  . �5    "   ��  � ��
 �iii�6?   5!      5#      5%      5&      5'      .��5(      � .+�5)   
   �� $
��Name��6   $
��Left=�6    $��Center=�6=   $��20(�6X   $��Center=�6f   $��Segoe UI Black)�6�   $��37��6�   $	��117��6�   $��
6,59,0,326q�6�   �� 5*   
   -   5         ��Name$ tbReminderName��5*   F   ���	#FFFBF7F7$��Segoe UI Black)�6^   $��16(�6{   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��10,96,225,279q�6�   ��6   ��  �� Path$
 Name�6�   �� 5+   
   $��Description��6   $
��Left=�6(   $��Center=�6E   $��20(�6`   $��Center=�6n   $��Segoe UI Black)�6�   $��37��6�   $	��142��6�   $��6,143,0,242q�6�   �� 5,   
   -   5        $ tbReminderDescription��5,   K   ���	#FFFBF7F7$��Segoe UI Black)�6j   $��16(�6�   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��10,181,225,190q�6�   ��6   �� $ Description�6�   �� 5-   
   $��Period��6   $
��Left=�6"   $��Center=�6?   $��20(�6Z   $��Center=�6h   $��Segoe UI Black)�6�   $��37��6�   $	��117��6�   $��6,237,0,148q�6�   �� 5.   
   -   5        $ tbPeriod��5.   I   ���	#FFFBF7F7$��Segoe UI Black)�6[   $��16(�6x   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��10,274,225,102q�6�   ��6   �� $ Period�6�   �� 51   
   -   5        $ tbReminderTime��51   z   #��[  6-   $ hh:mm��6W   ���	#FFFBF7F7$��Segoe UI Black)�6�   $��16(�6�   $��Center=�6�   $��3q�6�   ���	#FF4D4B4B$��217,274,18,102q�6  ��6   �� $
 Time�.��6(  53      &   System.Windows.Controls.Calendar  55   
   -   5        $��dpReminderDate��55   :   $
��Left=�6P   $��
217,69,0,0q�6k   $	��Top=�6   $	��170��6�      SelectedDate 6   �� $ SelDate�6�   �� 56   
   $��Create reminder��6@   $��18(�6Z   $��5q�6i   ���	#FF4D4B4B$��217,351,18,10q�6�   ��6   �� $ CreateReminderCommand�6�   �� 57   
   $
��Time��6   $
��Left=�6    $��Center=�6=   $��20(�6X   $��Center=�6f   $��Segoe UI Black)�6�   $��37��6�   $	��117��6�   $��217,237,0,148q�6�   �� 58   
   $
��Date��6   $
��Left=�6    $��Center=�6=   $��20(�6X   $��Center=�6f   $��Segoe UI Black)�6�   $��37��6�   $	��117��6�   $��217,32,0,353q�6�   �� 59   
   -   5        $��Close��59      $��18(�6!   $��5q�60   ���	#FF4D4B4B$��10,351,225,10q�6k   5;      5<      