   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	       Bolnica.View.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Login��5	   	   $	��720��6   $
��1280��6$   $��Segoe UI Black)�61   ���	#FFBBB6B6 � 	Resources 5
         MyWaterMarkStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name
	 � Tag
 �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value  DefaultTextBoxStyle ' #ToolTipWithErrorMessageOnErrorStyle �� BasedOn �� Triggers �� RelativeSource �� Path  RedBackgroundOnErrorStyle " CustomErrorControlOnErrorStyle ��Name �� ElementName��%Z  &	        '�� �    &	 �    &	 h    7  &	 5    7  &	 �    7  �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� 
����������	#FF7D8683$��1q�6P   �� 5      $ PART_ContentHost��6+   $��5,0,0,0q�6E   $��Center=�6V   �� 5      $ WaterMarkLabel��65   $��5,0,0,0q�6$   #��z	 6M   $��Center=�6m   $y�	Collapsed=�5       
�������$��Arial)�6I   5      
 5      ]� 5       5   "   �� 5   &    � ��$  ��6@   ./�5   "   �� $ WaterMarkLabel��6?    � y�$ Visible=�6[   5      P� 5       � {� .  . �5   "   ��  � ��
 �iii�6?   5      5       5"      5#      �� 5%   
   " ��6   .�5&      ��  � ��$ 5q�6'   �� 5'       � ��$ Center=�62   5(      �� 5)   
   " ��6,   .�5*      ��  � ��$ 5q�6'   �� 5+       � ��$ Center=�62   5,      �� 5.   
   " ��6<   8    5/      P� 50       �@=�HasError . . �51      ��  �@�ToolTip 60   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�52      54      �� 56   
   " ��62   8    57      P� 58       �@=�HasError . . �59      ��  � ��
 �  ��63   5:      5<      �� 5>   
   " ��67   8   .�5?      ��  �@=�ErrorTemplate 5@      �� 5A      .R�5B      �� .+�5C      �� $ placeholder��68   �� 5D      $��11(�6(   $��Italic$�66   
���  ����5E   (   �� $ placeholder��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5F      5G      5I      5J      5M      .��5P      �  � RowDefinitions 5Q   
   �� 5R      $
��100* �6   �� 5S      $
��100* �6   �� 5T      $	��45* �6   �� 5U      $	��43* �6   �� 5V      $	��44* �6   �� 5W      $	��43* �6   �� 5X      $	��66* �6   �� 5Y      $	��90* �6   �� 5Z      $
��149* �6    � ColumnDefinitions 5\   
   �� 5]      $	��21* �6   �� 5^      $	��24* �6   �� 5_      $	��22* �6   .+�5a   
   �� $��1��6   $��2��6    $��Username��6-   $
��Left=�6A   $��Center=�6^   $��20(�6y   $��Center=�6�   $��Segoe UI Black)�6�   $��37��6�   $	��0,4q�6�   $	��108��6�   �� 5b   
   -   5         ��Name$ tbUser��5b      $��1��6"   $��3��62   $��Segoe UI Black)�6@   ���	#FFECDFDF$��3q�6s   ���	#FF4D4B4B$��20(�6�   $��Center=�6�   �� 5c   
   $��1��6   $��4��6    $��Password��6-   $
��Left=�6A   $��Center=�6^   $��20(�6y   $��Center=�6�   $��Segoe UI Black)�6�   $��38��6�   $	��0,3q�6�   $	��105��6�   G� 5d   
   -   5         G�Name$ tbPass��5d      $��1��6&   $��5��66   $��Segoe UI Black)�6D   ���	#FFECDFDF$��3q�6w   ���	#FF4D4B4B$��20(�6�   $��Center=�6�   �� 5e   
   -   5         ��Name$ TestText��5e      
���  �� J� Opacity$	 0.6Q�67   $��Medium"�6E   $��13(�6Y   $
��Left=�6g   $��0,10,0,0q�6�   $��6��6�   $
��Wrap=�6�   $	��Top=�6�   $	��243��6�   $��1��6�   �� 5f   
   -   5        $��Login��5f      $��1��6"   $��7��62   ���	#FFECDFDF$��5q�6V   ���	#FF4D4B4B$��27(�6�   6�   �� 5g   
   $��1��6   $6��0/ZdravoKorporacija;component/Images/hosplogo.png��6    $��0,83,0,0q�6Z   $��2��6l   5h      5i      