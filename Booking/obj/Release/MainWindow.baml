   M S B A M L   `   `   `  ���� B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking      Booking.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Booking       � Title$E  ?Бронирование аудиторий в колледже��$	��440��$	��800��$	��440��$	��800��$	��440��$	��800�� � Icon$ 	/icon.png�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ 	/blue.jpg��.��� $
��auto��$
��auto��$��Center=�$��Center=�.+��� $
��auto��$
��auto�����	#7F8ADDFE �� Orientation$ Vertical=�$��Center=�$��Center=�.+��� $
��auto��$��
10,0,10,-1q�.+��� $��Авторизация��$
��Bold"�$��30(�$��Center=����	#FFEEFBFF$��Stretch=�$��0,5,0,0q��� $��30��$ 
Horizontal=�$��Center=�$��
10,15,10,0q�.+��� $��
Логин��$��62��$��5,0,0,0q�$��14(����	#FF064CDF$
��Bold"��� -    ��Name$ 	txt_login�� �� TextWrapping$ NoWrap=�$�� ��$	��198��$��30��$��0,0,5,0q�$
��Left=�$��Center=�4  .System.Windows.Automation.AutomationProperties   HelpText$ 
Логин��$��Center=� �� 	MaxLength$ 25���� $��30��$	��270��$ 
Horizontal=�$��
10,10,10,0q�$��Center=�.+��� $��Пароль��$��62��$��5,0,0,0q�$��14(����	#FF064CDF$
��Bold"�$
��Left=�G� -   	 G�Name$	 txt_password��$	��198��$��30��$��0,0,5,0q�$
��Left=�$��Center=�$��Right=�
 G� 	MaxLength$
 25���� $��21��$	��270��$ 
Horizontal=�$��
10,10,10,0q�$��Stretch=�$��Center=�.+�	� -    	�Name$ 
rb_teacher�� 	� 	GroupName$ acount��$ ��Преподаватель�� d� 	IsChecked$
 TrueY�$��0,0,0,0q�$��14(����	#FF064CDF$
��Bold"�$��Center=�	� -   $ rb_admin��$ acount��$ ��Администратор��$ falseY�$��5,0,0,0q�$��14(����	#FF064CDF$
��Bold"��� -    ��Name$ panel_error��$��30��$	��270��$��	10,5,10,5q�.+��� -    ��Name$ 
lb_message��$�� ��$��5,0,5,0q����	#FFE80B0B$
��Bold"�$��Center=��� $��30��$	��270��$ 
Horizontal=�$��Center=�$��Bottom=�$��	10,0,10,7q�.+��� -    ��Name$ chk_remember��$
��Left=�$��Center=�$��0,0,30,0q����	#FF064CDF$
��Bold"�$��90��.��запомнить�� -    ��Name$ btn_in��$��
Войти��$	��150��$��30�����	#FF4C8BF2$��0,0,10,0q�$��14(����	#FF013870$
��Bold"����	#FF80B4F0$��Right=�$��Center=��� $��30��$	��270��$ 
Horizontal=�$��Stretch=�$��Stretch=�$��
10,0,10,10q�.+��� -	   $ btn_out��$��
Выход��$	��270��$��30�����	#FF4C8BF2$��14(����	#FF013870$
��Bold"�$��Center=����	#FF80B4F0