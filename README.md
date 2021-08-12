# LiftTruck

### Notes to self
Project is created with `ASP.NET Core Hosted` and `Progressive Web Application`.

1. `ASP.NET Core Hosted` --> Provides a solution where we can already make use of a Web API. So a fullstack
application in one solution.

2. **TBD**

[YT link](https://www.youtube.com/watch?v=hnVh1yVmSAU&ab_channel=PatrickGod) used for general information.

## Client project
`Program.cs` is the starting point. Used to register new services written by ourselves or services used by 
adding new packages.

And any page will be rendered in the the `@Body` part of the layout.

You can build custom layouts too and replace them with the main layout in `App.razor` component.

# Components
Components in `Blazor` is the `Razor` files. That's why they are called **Razor components**.

A component can be used by adding a tag with its exact name.


### `_Imports.razor`
Contains the global using directives imports that we use. If you don't want to add references in 
single components, and them in this file.

## Server project
`Startup.cs` you find the configure services and the configure methods:

1. `configure services` configures the applications services (the reusable components 
that provides the apps functionality).

2. `configure methods` creates the server apps request processing pipeline, meaning how the
app responds to `http` requests.

### `Startup.cs`
Specified when the apps host is build and you can see that in the `Program.cs` file, which is done in 
`CreateHostBuilder` method.

### `OnInitializedAsync()`
Is part of the component lifecycle.

## Open Icons (oi)
[OI Icons](https://useiconic.com/open)

### Implementing dark mode
Followed this [tutorial](https://www.youtube.com/watch?v=a6W1e4QKYhw&ab_channel=gavilanch3) with own
modifications implemented underway.

With .Net5, components can now have their own css files, **css isolation**.


#### Responsive Design
[Link](https://www.bluecorona.com/faq/what-is-a-responsive-website-design/)

#### Flex design
[Link](https://flexboxfroggy.com/)

##### Design templates for service page
[link](https://codepen.io/dasshounak/pen/QWKKYdj)

[link](https://codepen.io/ainalem/pen/GRqPwoz)