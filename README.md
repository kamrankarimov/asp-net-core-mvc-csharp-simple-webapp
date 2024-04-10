№ Asp.Net Core (MVC), C# - Simple Web Application

The purpose of doing this little project is to improve myself and create a history by committing each step.

Ready-made MVC structure was not used. MVC architectural patterns were written on an empty Asp.Net Core project.

Layout, PartialView, ViewComponent and etc. A small modular structure was created with

ViewComponents were enabled to receive data directly from the Models, to avoid overloading the controllers.

Components were adjusted on an application basis, not on a controller basis, to reduce costs.

The purpose of doing this little project is to improve myself and keep it like a notebook for myself by fulfilling each step with determination.

Data was moved to views sometimes with ViewBag, sometimes with Tuple object, sometimes with Temp data.

Important static or dynamic parts of the design and others were made using tag helper with razor technology.

Two small forms were prepared and Validations were added to these forms.

Server side validation was done with the Fluent Library and Model States, and later the jquery ajax library was added for Client side validation operations.

The reason why I use Fluent validations and keep the validation processes in the model in separate folders is to ensure that this structure complies with the SOLID Single Responsibility principle.

On the product list page, json data was received and processed by sending a query to the controller.

Fluent Validations and NewtonSoftJson were used as dependency.
