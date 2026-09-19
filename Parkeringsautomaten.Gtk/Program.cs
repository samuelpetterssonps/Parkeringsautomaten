var application = Adw.Application.New("io.github.samuelpetterssonps.parkeringsautomaten", Gio.ApplicationFlags.FlagsNone);
application.OnActivate += (sender, args) =>
{
    // Duration
    var durationBox = Gtk.Box.New(Gtk.Orientation.Vertical, 4);
    var durationLabel = Gtk.Label.New("Hur lång tid?");
    var durationAdjustment = Gtk.Adjustment.New(0, 0, 60, 1, 5, 0);
    var durationEntry = Gtk.SpinButton.New(durationAdjustment, 1, 0);
    
    durationBox.Append(durationLabel);
    durationBox.Append(durationEntry);
    
    // Day of Week
    var dayOfWeekBox = Gtk.Box.New(Gtk.Orientation.Vertical, 4);
    var dayOfWeekLabel = Gtk.Label.New("Vad för veckodag?");
    var mondayRadio = Gtk.CheckButton.NewWithLabel("Måndag");
    var tuesdayRadio = Gtk.CheckButton.NewWithLabel("Tisdag");
    var wednesdayRadio = Gtk.CheckButton.NewWithLabel("Onsdag");
    var thursdayRadio = Gtk.CheckButton.NewWithLabel("Torsdag");
    var fridayRadio = Gtk.CheckButton.NewWithLabel("Fredag");
    var saturdayRadio = Gtk.CheckButton.NewWithLabel("Lördag");
    var sundayRadio = Gtk.CheckButton.NewWithLabel("Söndag");

    tuesdayRadio.Group = mondayRadio;
    wednesdayRadio.Group = mondayRadio;
    thursdayRadio.Group = mondayRadio;
    fridayRadio.Group = mondayRadio;
    saturdayRadio.Group = mondayRadio;
    sundayRadio.Group = mondayRadio;
    
    dayOfWeekBox.Append(dayOfWeekLabel);
    dayOfWeekBox.Append(mondayRadio);
    dayOfWeekBox.Append(tuesdayRadio);
    dayOfWeekBox.Append(wednesdayRadio);
    dayOfWeekBox.Append(thursdayRadio);
    dayOfWeekBox.Append(fridayRadio);
    dayOfWeekBox.Append(saturdayRadio);
    dayOfWeekBox.Append(sundayRadio);
    
    // Calculate button
    var calculateButton = Gtk.Button.NewWithLabel("Räkna ut");

    // Root container
    var container = Gtk.Box.New(Gtk.Orientation.Vertical, 20);
    container.SetMarginStart(10);
    container.SetMarginTop(10);
    container.SetMarginEnd(10);
    container.SetMarginBottom(10);
    container.SetMarginBottom(10);
    container.Append(durationBox);
    container.Append(dayOfWeekBox);
    container.Append(calculateButton);
    
    // Result

    var resultBox = Gtk.Box.New(Gtk.Orientation.Vertical, 0);
    
    calculateButton.OnClicked += (button, eventArgs) =>
    {
        var firstChild = resultBox.GetFirstChild();
        if (firstChild != null)
        {
            resultBox.Remove(firstChild);
        }

        var result = Parkeringsautomaten.Lib.Cost.Calculate((int)Math.Round(durationEntry.Value), DayOfWeek.Monday);
        var resultLabel = Gtk.Label.New($"{result}");
        resultBox.Append(resultLabel);
    };
    
    container.Append(resultBox);
    
    // Window
    var window = Gtk.ApplicationWindow.New((Adw.Application) sender);
    window.Title = "Parkeringsautomaten";
    window.SetDefaultSize(300, 500);
    window.SetChild(container);
    window.Show();
};
return application.RunWithSynchronizationContext(null);
