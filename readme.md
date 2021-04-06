# WarehouseUI

Winform application, UI for warehouse managment system. Enables you to add, edit, delate, and view, contents of sql database that represent real warehouse objects.

# WarehouseLibrary

Csharp class library that contains models for database tables, and some utility classes

# WarehouseWeb

MVC web application that allows to view products from database, create and send orders regarding specific products

# WarehouseWebService

Web servive providing basic functionality for WarehouseClientUI

# WarehouseClientUI

Winform, UI for warehouse Clients, allows to browse warehouse items, and send new orders regarding specific products

# WarehouseServer

Sql server database, with sample data, stored procedures, and test query that allows to quickly check functionality of every piece.

# Notes

All parts of app are actually ready but there is still room for improvment.

To do:

- move all the clumsy code for form validation into a single class that handles writing messages
- tweak the database, so there also is Users table containing all of the user's info and all of his orders
- make it so you have an option to register as User and all of your info is automaticly apearing in the form so you can only check it and correct instead of typing it all over again
- make option to cancel order that hasn't been completed yet
