   M S B A M L   `   `   `  ���� B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking      Booking.TeacherEdit   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Booking       � Title$   Преподаватель��$	��610��$	��310��$	��610��$	��310��$	��610��$	��310�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ 	/fon4.jpg��.��� .+��� $	��280��$	��510��$��Center=�$	��Top=�$��0,10,0,0q����	#B2D8F1FF.+��� $	��160��$	��230��.+��� -    ��Name$ imgaddimage��$	��140��$	��220��$��0,15,0,0q��� -   $��scroll����. $	��350��.���� $��Информация��$
��Bold"�.����  �� Orientation$ Vertical=�.+��� $��Фамилия*���� -    ��Name$ txtaddfname�� �� TextWrapping$
 Wrap=� �� 	MaxLength$ 25���� $��Имя*���� -   $ txtaddsname��$
 Wrap=�$�� ��$ 25���� $��Отчество*���� -   $ txtaddfathname��$
 Wrap=�$�� ��$ 25���� $��Должность���� -   $ txtaddposition��$
 Wrap=�$�� ��$	 255���� $��Телефон���� -   $ 	txtaddtel��$
 Wrap=�$�� ��$ 12���� $��Email���� -   $ txtaddemail��$
 Wrap=�$�� ��$	 319���� $ 
Horizontal=�$��0,10,0,0q�$��Stretch=�$��Center=�.+��� $��Картинка���� -	   $��Center=�$��Center=�$��70��$��	110,0,0,0q�.��Загрузить..�� -
   $ txtaddimage��$
 Wrap=�$�� ��$
 1000��$��0,0,0,3q��� $ 
Horizontal=�$��Bottom=�$��Center=�$��0,0,0,5q�$	��287��.+��� -    ��Name$ 
btnaddEdit��$��Сохранить��$��5,5,5,5q�$��126.5�����	#CC37A3D8$
��Bold"�$��14(�$��30��$��Center=�$��Center=�{�.  �� -   $ 	btncancel��$��Отменить��$��10,5,5,5q�$��126.5�����	#CC37A3D8$
��Bold"�$��14(�$��30��$��Center=�$��Center=�