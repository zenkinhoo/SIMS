   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   A%clr-namespace:Bolnica.View.ValidationBolnica.View.Validation  5          Bolnica.View.RateDoctor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	   6util%clr-namespace:Bolnica.View.Validation     5      -   5          � WindowStyle$  
ToolWindow=�5       � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ 
RateDoctor��5   	   $	��390��6   $	��440��6)   $��Segoe UI Black)�65   ���	#FFBBB6B6.��5      �  � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��28* �6   �� 5      $	��47* �6   �� 5      $	��64* �6   �� 5      $	��44* �6   �� 5      $	��45* �6   �� 5      $	��44* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��3* �6   �� 5      $
��2.5* �6   �� 5       $
��2.5* �6   .+�5"   
   �� $��1��6   $��1��6!   $��4��6.   $5��//ZdravoKorporacija;component/Images/profile.png��6?   6z   �� 5#   
   -   5         ��Name$ 	labelName��5#      $��1��6$   $��5��64   $��Lazar��6A   $��Center=�6R   $��Center=�6q   $��14(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5$   
   -   5        $ labelSurname��5$      $��1��6'   $��6��67   $��Mitrovic��6D   $��Center=�6X   $��Center=�6w   $��14(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5%   
   -   5        $ labelSpecialty��5%      $��1��6(   $��7��68   $��
Psihijatar��6E   $��Center=�6[   $��Center=�6z   $��14(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5&   
   $��2��6   $��1��6    $��2��6-   $��Enter your rating here:��6B   $��Center=�6e   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   $��Center=�6�   $��13(�6  $��26��6  $
��50,2q�6  $	��156��6*  �� 5'   
   -   5        $��tbRate��5'   C   $��2��6   $��1��6"   $��2��6/   $��Segoe UI Black)�6R   ���	#FFFBF7F7$��2q�6�   ���	#FF4D4B4B$��Center=�6�   
 � Tag$ Enter first name��6�   $��Italic$�6�    �� TextAlignment$ Center=�6�   $��25��6  $��Bottom=�6#  $��	30,0,30,5q�6>  $��2��6Q  .��6c  ��5(      �� 5)      	 �� Path$
	 rate�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�6&    �� Mode$ TwoWay=�6M    �� ValidationRules 5+      /  )Bolnica.View.Validation.NumbersValidation  5,      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�61   5.      .��5/       =� ErrorTemplate 50      �� 51      .R�52      �  53      �� 54      �� 55       57      �� 58      �� 59      .+�5;      �� $��0��64   $��0��6A   6S   �� 5<      $��0��6$   $��1��64   $��13(�6A   
���  ����6O   �� *[0].ErrorContent+6�   �� 5=      $��20(�6    $��0��6.   $��1��6;   
���  ��$��Segoe MDL2 Assets)�6]   $	����6|   6�   5>      5?      .��5@   (   5A      �� 5B   
   $��2��6   $��3��6    $��2��6-   $��Enter your comment here:��6B   $��Center=�6f   $��Center=�6�   $��Segoe UI Black)�6�   $��13(�6�   $��28��6�   $��
41,19,39,0q�6�   $	��176��6�   �� 5C   
   -   5         ��Name$ 	tbComment��5C   h   $��2��6   $��4��6"   $��2��6/   $��3��6C   $��3q�6T   ���	#FF4D4B4B$��Segoe UI Black)�6�   ���	#FFFBF7F7$��Center=�6�   $ Center=�6�   $��
30,0,30,10q�6  �� 5D   
   -   5        $��2��5D      $��7��6!   $��Rate Doctor��6.   $��13(�6D   $��Segoe UI Black)�6R   $��3q�6n   ���	#FF4D4B4B$	��5,0q�6�   �� 5E   
   -   5        $��3��5E      $��7��6!   $��Cancel��6.   $��13(�6?   $��Segoe UI Black)�6M   $��3q�6i   ���	#FF4D4B4B$	��5,0q�6�   5G      5H      