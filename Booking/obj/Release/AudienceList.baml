   M S B A M L   `   `   `  ���� B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking      Booking.AudienceList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Booking       � Title$%  Список аудиторий��$	��450��$	��855��$	��450��$	��855�� � Icon$ 	/icon.png�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ 	/fon8.jpg��.���  � ColumnDefinitions �� .+��� -    ��Name$ txtnameadmin��$��
Test Test ��$
��Left=�$��0,15,0,0q�$	��Top=����	#FF0495D8$��Center=�$��Center=����	#FF281A5D$
��Bold"�$��14(��� $��50�� �� Orientation$ 
Horizontal=�$	��540��$��Bottom=�$
��Left=�$��	30,0,0,10q�.+��� -    ��Name$ 	btnreturn��$��
Назад�����	#FF469ECE���	#FF003970$��14(�$	��125��$��40��$��0,5,5,5q�$
��Bold"��� -   $ btnaddaudience��$��Добавить��$��10,5,5,5q�$��126.5�����	#E572B7E0$
��Bold"�$��14(����	#FF013870�� -   $ 	btnchange��$��Изменить��$��5,5,5,5q�$��126.5�����	#E572B7E0$
��Bold"�$��14(����	#FF013870�� -   $ 	btndelete��$��Удалить��$��5,5,0,5q�$��126.5�����	#E572B7E0$
��Bold"�$��14(����	#FF013870�� $	��230��$	��335��$��Right=�$��Bottom=�$��	0,0,30,60q�����  �� EndPoint$ 0.5,1&�	 �� 
StartPoint$	 0.5,0&�.��� 
 � Color$
 	#FF70B8DE��� $
 	#CC70B8DE�� � Offset$ 1Q�.+��� -   $��scroll����. $	��335��.���� $��Информация��$
��Bold"�
�������.���� $ Vertical=�.+��� $#��Номер аудитории�����	#FF003970$
��Bold"��� -    ��Name$ 	txtnumber�� �� TextWrapping$
 Wrap=�$�� �� �� 
IsReadOnly . �� $��Этаж�����	#FF003970$
��Bold"��� -   $ txtfloor��$
 Wrap=�$�� �� . �� $��Описание�����	#FF003970$
��Bold"��� -	    ��Name$ txtinventory��$��15,0,5,0q�$��Normal"�$��181.2��$��181.2��$��181.2��$
��Wrap=��� -
    ��Name$ listaudience��$	��540��$	��335��$
��Left=�$��Bottom=�$��	30,0,0,60q����	#CC469ECD �� View �� .P��� -   
idaudience�� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� -   	naudience��$��№ аудитории��$
 auto�� �� $ Number��� -   	faudience��$��Описание��$
 auto�� �� $ Peculiarities�