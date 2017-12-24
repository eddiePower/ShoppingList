# ShoppingList - December 2017.

<b>General project description.</b>

<p>A WPF application im writing to help practice the technology and ways to identify correct properties for View Models in the M.V.VM design pattern.
I intend to design further functionality as i go, to begin a simple shopping list app that allows for adding, editing and removing of items to a list.
Next I will add database support to make sure closing the app does not wipe out the data stored just basic CRUD will be enabled.  Finally i will try
to encorperate a server holding JSON data for the list items, meaning multiple clients could read and update the same list (this is the nice to have part).
</p>

App Structure

<b>Views</b>
<ul>
  <li>MainWindow.xaml - loads all needed components of the ui</li>
  <li>CrudMenu.xaml - Panel of buttons to fire off ICommands Add, Edit, Delete</li>
  <li>ShoppingList.xaml - Main shopping List grid for showing all the list items</li>
  <li>ItemDetailEntry.xaml - UI element that appears to Add or edit a list item</li>
</ul>

<b>ViewModels</b>
<ul>
   <li>MainWindowViewModel.cs</li>
   <li>CrudMenuViewModel.cs</li>
   <li>ShoppingListViewModel.cs</li>
   <li>ItemDetailEntryViewModel.cs</li>
</ul>

<b>Models</b>
<ul>
  <li>TBA</li>
</ul>

<p>
This is just a demo application to help me in my work which is a very large complex codebase in C# moving now from WinForm / WPF to as pure WPF
as we can get in the do minimal harm approach to testing and tightly coupled components.
</p>
