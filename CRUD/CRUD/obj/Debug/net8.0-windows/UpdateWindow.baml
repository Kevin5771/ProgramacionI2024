   M S B A M L   `   `   `  ����?  ;CRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CRUDCRUD  5   	       CRUD.UpdateWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:CRUD     5   	     � Title$  UpdateWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
      �� -   5         ��Name$ 
txtCliente��5
      $��Center=�6.   $��0,99,0,0q�6K    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��265,101,0,0q�6B   $
��Wrap=�6W   $��Cliente:��6k   $	��Top=�6{    J� RenderTransformOrigin$ 0.243,-0.67&�6�   �� 5   
   -   5        $ txtidProduct��5      $��Center=�6(   $��	0,139,0,0q�6E   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��265,141,0,0q�6G   $
��Wrap=�6\   $��Id Prodcuto��6p   $	��Top=�6�   $ 0.243,-0.67&�6�   �� 5   
   -   5        $ Cantidad��5      $��Center=�6$   $��	0,219,0,0q�6A   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $ textBlock_Copy1��5      $
��Left=�6-   $��265,221,0,0q�6H   $
��Wrap=�6]   $��Cantidad��6q   $	��Top=�6�   $ 0.243,-0.67&�6�   �� 5   
   -   5        $ Precio��5      $��Center=�6"   $��	0,268,0,0q�6?   $
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��120��6�   �� 5   
   -   5        $ textBlock_Copy2��5      $
��Left=�6-   $��265,270,0,0q�6H   $
��Wrap=�6]   $��Precio��6q   $	��Top=�6   $ 0.243,-0.67&�6�   �� 5   
   -	   5        $ txtId��5      $��Center=�6!   $��0,66,0,0q�6>   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   �� 5   
   -
   5        $ textBlock_Copy3��5      $
��Left=�6-   $��
265,68,0,0q�6H   $
��Wrap=�6\   $��Id��6p   $	��Top=�6z   $ 0.243,-0.67&�6�   �� 5   
   -   5         ��Name$ btnCrear��5      $��Guardar��6#   $��Center=�65   $��	0,313,0,0q�6R   $	��Top=�6e   6}   �� 5   
   -   5        $ textBlock_Copy4��5      $
��Left=�6-   $��265,185,0,0q�6H   $
��Wrap=�6]   $��	Productos��6q   $	��Top=�6�   $ 0.243,-0.67&�6�   �� 5   
   -   5         ��Name$ 
cbCarreras��5       �� DisplayMemberPath$ NombreProducto��5       �� SelectedValuePath$ Id��5      $��Center=�5      $��	0,179,0,0q�6*   $	��Top=�6=   $	��120��6U   	 �� SelectedValue	 5   '   �� *
IdProducto+
 �� Mode$
 OneWay=�5   U   5      5      