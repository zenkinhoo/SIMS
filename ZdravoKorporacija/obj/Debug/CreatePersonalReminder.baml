   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BolnicaBolnica  5   	   $    Bolnica.CreatePersonalReminder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Bolnica     5   	     � Title$  CreatePersonalReminder��5   	   $	��450��6(   $	��460��65   .��5	      � .+�5
   
   �� $��Reminder name: ��6   $
��Left=�6*   $��	60,81,0,0q�6E   $	��Top=�6X   �� 5   
   -   5         ��Name$ tbReminderName��5      $
��Left=�6*   $��23��6E   $��
167,83,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ tbDescription��5      $
��Left=�6)   $��23��6D   $��167,136,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ tbPeriod��5      $
��Left=�6$   $��23��6?   $��185,242,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   $��Description: ��6   $
��Left=�6(   $��
60,133,0,0q�6C   $	��Top=�6W   �� 5   
   $��Reminder Time: ��6   $
��Left=�6*   $��
60,195,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Period:��6   $
��Left=�6"   $��
71,239,0,0q�6=   $	��Top=�6Q    J� RenderTransformOrigin$ 1.016,-1.262&�6i   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dpReminderDate��5      $
��Left=�6+   $��185,196,0,0q�6F   $	��Top=�6[   �� 5   
   -   5        $��Confirm��5      $
��Left=�6#   $��116,340,0,0q�6>   $	��Top=�6S   $	��134��6k   $��43��6w   6�   �� 5   
   -   5        $ tbReminderTime��5      $
��Left=�6*   $��23��6E   $��307,196,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $��87��6�   5      5      