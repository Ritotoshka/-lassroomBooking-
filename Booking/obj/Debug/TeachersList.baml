   M S B A M L   `   `   `  ����B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking  5   	       Booking.TeachersList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Booking     5   	     � Title$/  )Список преподавателей��5   	   $	��700��6'   $
��1100��67   $	��700��6G   $
��1100��6W    � Icon$ 	/icon.png��6g    � WindowStartupLocation$ CenterScreen=�5
   	   ��5      �� 5   
    �� ImageSource$ 	/fon8.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   � $	��620��6   $��20,20,30,20q�6     5      �� 5      $��* �6#   �� 5      $
��0.4* �6#    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� -   5         ��Name$ listteacher��5   4   $��0��6   $��0��6'   $��Center=�6u   $��Stretch=�6�   ���	#CC469ECD$��	20,0,20,0q�6�   $	��580��6  $	��605��6   �� View 5       �� 5!      .P�5"      �� -   5        	idteacher�� �� Width$ 0��5"   e   	 �� DisplayMemberBinding	 6<   �� 
 �� Path$
 Id�6e   �� 5#      -   5        fteacher��$��Фамилия��5#   g   	 6;   �� $
 Fname�6g   �� 5$      -   5        steacher��$��Имя��5$   g   	 6;   �� $
 Sname�6g   �� 5%      -   5        fathteacher��$��Отчество��5%   m   	 6>   �� $
 Fathname�6m   �� 5&      -   5        pteacher��$��Должность��5&   j   	 6;   �� $
 Position�6j   5'      5)      � 5+      $��1��6   $	��250��6#    5-      �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   .+�52      �� $��0��6   $��0,0,0,10q�6*   ��53      �� 54       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��55      �  � Color$ 	#FF70B8DE��6+   � 56      $ 	#CC70B8DE��6+    � Offset$ 1Q�6=   57      .+�59      �� $	��180��6!   .+�5:      �� -   5         ��Name$ imageteacher��5:       $��10,10,10,10q�66   $	��160��6L   5;      �� 5=      $��Информация��6   $
��Bold"�63   
�������$	��379��6X   .��5>      ��  �� Orientation$ Vertical=�6%   .+�5?      �� $��Фамилия��6$   ���	#FF003970$
��Bold"�6M   �� 5@      -   5         ��Name$ txtfname��5@   &    �� TextWrapping$
 Wrap=�68   $�� ��6L    �� 
IsReadOnly . 6T   �� 5A      $��Имя��6$   ���	#FF003970$
��Bold"�6I   �� 5B      -	   5        $ txtsname��5B   &   $
 Wrap=�68   $�� ��6L    . 6T   �� 5C      $��Отчество��6$   ���	#FF003970$
��Bold"�6N   �� 5D      -
   5        $ txtfathname��5D   &   $
 Wrap=�6;   $�� ��6O    . 6W   �� 5E      $��Должность��6$   ���	#FF003970$
��Bold"�6O   �� 5F      -   5        $ txtposition��5F   &   $
 Wrap=�6;   $�� ��6O    . 6W   �� 5G      $��Телефон��6$   ���	#FF003970$
��Bold"�6M   �� 5H      -   5        $ txttel��5H   &   $
 Wrap=�66   $�� ��6J    . 6R   �� 5I      $��Email��6$   ���	#FF003970$
��Bold"�6K   �� 5J      -   5        $ txtemail��5J   &   $
 Wrap=�68   $�� ��6L    . 6T   5K      5L      5M      5N      � 5O      $��1��6   $��0��6    $	��605��60   $��Center=�6<    5P      �� 5Q      $
��auto �6+   �� 5R      $
��auto �6+   �� 5S      $
��auto �6+   �� 5T      $
��auto �6+   .+�5V      �� -   5        $��0��5V      $��
Назад��6)   ���	#FF469ECE���	#FF003970$��16(�6{   $��0,5,0,0q�6�   $
��Bold"�6�   $��2,9,0,9q�6�   $	��140��6�   �� 5W      -   5         ��Name$ 	btnchange��5W   )   $��1��6   $��Изменить��6<   $��15,5,0,0q�6O   ���	#E572B7E0$
��Bold"�6y   $��16(�6�   ���	#FF013870$��1,9,1,9q�6�   $	��140��6�   �� 5X      -   5        $ btnaddteacher��5X   )   $��2��6   $��Добавить��6@   $��15,5,0,0q�6S   ���	#E572B7E0$
��Bold"�6}   $��16(�6�   ���	#FF013870$��1,9,1,9q�6�   $	��140��6�   �� 5Y      -   5        $ 	btndelete��5Y   )   $��3��6   $��Удалить��6<   $��15,5,0,0q�6N   ���	#E572B7E0$
��Bold"�6x   $��16(�6�   ���	#FF013870$��1,9,1,9q�6�   $	��140��6�   5Z      5\      5]      5^      