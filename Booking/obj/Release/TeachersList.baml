   M S B A M L   `   `   `  ���� B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking      Booking.TeachersList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Booking       � Title$/  )Список преподавателей��$	��700��$
��1100��$	��700��$
��1100�� � Icon$ 	/icon.png�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ 	/fon8.jpg��.���  � ColumnDefinitions �� .+�� $	��620��$��20,20,30,20q� �� $��* ��� $
��0.4* � � RowDefinitions �� $
��auto ��� $
��auto �.+��� -    ��Name$ listteacher��$��0��$��0��$��Center=�$��Stretch=����	#CC469ECD$��	20,0,20,0q�$	��580��$	��605�� �� View �� .P��� -   	idteacher�� �� Width$ 0��	 �� DisplayMemberBinding	 �� 
 �� Path$
 Id��� -   fteacher��$��Фамилия��	 �� $
 Fname��� -   steacher��$��Имя��	 �� $
 Sname��� -   fathteacher��$��Отчество��	 �� $
 Fathname��� -   pteacher��$��Должность��	 �� $
 Position�� $��1��$	��250�� �� $
��auto ��� $
��auto �.+��� $��0��$��0,0,0,10q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF70B8DE��� $ 	#CC70B8DE�� � Offset$ 1Q�.+��� $	��180��.+��� -    ��Name$ imageteacher��$��10,10,10,10q�$	��160���� $��Информация��$
��Bold"�
�������$	��379��.����  �� Orientation$ Vertical=�.+��� $��Фамилия�����	#FF003970$
��Bold"��� -    ��Name$ txtfname�� �� TextWrapping$
 Wrap=�$�� �� �� 
IsReadOnly . �� $��Имя�����	#FF003970$
��Bold"��� -	   $ txtsname��$
 Wrap=�$�� �� . �� $��Отчество�����	#FF003970$
��Bold"��� -
   $ txtfathname��$
 Wrap=�$�� �� . �� $��Должность�����	#FF003970$
��Bold"��� -   $ txtposition��$
 Wrap=�$�� �� . �� $��Телефон�����	#FF003970$
��Bold"��� -   $ txttel��$
 Wrap=�$�� �� . �� $��Email�����	#FF003970$
��Bold"��� -   $ txtemail��$
 Wrap=�$�� �� . � $��1��$��0��$	��605��$��Center=� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� -   $��0��$��
Назад�����	#FF469ECE���	#FF003970$��16(�$��0,5,0,0q�$
��Bold"�$��2,9,0,9q�$	��140���� -    ��Name$ 	btnchange��$��1��$��Изменить��$��15,5,0,0q����	#E572B7E0$
��Bold"�$��16(����	#FF013870$��1,9,1,9q�$	��140���� -   $ btnaddteacher��$��2��$��Добавить��$��15,5,0,0q����	#E572B7E0$
��Bold"�$��16(����	#FF013870$��1,9,1,9q�$	��140���� -   $ 	btndelete��$��3��$��Удалить��$��15,5,0,0q����	#E572B7E0$
��Bold"�$��16(����	#FF013870$��1,9,1,9q�$	��140��