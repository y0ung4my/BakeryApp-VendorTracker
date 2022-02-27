# _Bakery App: Vendor Tracker_

#### By _**Amy Young**_

#### _Allows user to track vendors and their orders_

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _CSS/Bootstrap_

## Description

_This is a web application with pages for home, vendor, and order pages. The user creates new vendors using a form. Once a vendor is created, the user can create new orders for each vendor using another form. The application will display information for each vendor (including the vendor's orders) and order._

## Setup/Installation Requirements

**To clone the repository**
* _open terminal_
* _enter the following into terminal: `git clone https://github.com/y0ung4my/BakeryApp`_

**To run the application on your computer**
* _navigate to the `VendorTracker` directory_
* _in the console application of your choice, navigate to the `VendorTracker` directory then enter `dotnet restore` to install the files necessary to run the local server_
* _enter the URL into the web browser of your choice, usually `http://localhost:5000`_
* _follow the prompts on the web application_
* _to reload the server while updates to the code are made, enter `dotnet watch run`_

## Known Bugs

* _Tests which initially passed, failed after the web interface was added due to an index difference when the application runs in the browser. The project uses a work-around in the tests to find the right index_

## Ideas for Improvement
* _add functionality to delete vendors and orders_
* _add functionality to update details for vendors and orders _
* _add search functionality_

## License

MIT License

Copyright (c) 2022 Amy Young

Questions or comments: youngamy1223@gmail.com