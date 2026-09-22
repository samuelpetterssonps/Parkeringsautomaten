using Parkeringsautomaten.Lib;

var application = Adw.Application.New("io.github.samuelpetterssonps.parkeringsautomaten", Gio.ApplicationFlags.FlagsNone);
application.OnActivate += (sender, _) =>
{
    // Duration
    var durationBox = Gtk.Box.New(Gtk.Orientation.Vertical, 4);
    var durationLabel = Gtk.Label.New("Hur lång tid?");
    var durationAdjustment = Gtk.Adjustment.New(0, 0, 525960, 1, 5, 0);
    var durationEntry = Gtk.SpinButton.New(durationAdjustment, 1, 0);

    durationBox.Append(durationLabel);
    durationBox.Append(durationEntry);

    // Day of Week
    var dayOfWeekBox = Gtk.Box.New(Gtk.Orientation.Vertical, 4);
    var dayOfWeekStringList = Gtk.StringList.New(["Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag"]);
    var dayOfWeekDropdown = Gtk.DropDown.New(dayOfWeekStringList, null);

    dayOfWeekBox.Append(dayOfWeekDropdown);

    // Calculate button
    var calculateButton = Gtk.Button.NewWithLabel("Räkna ut");
    calculateButton.GetStyleContext().AddClass("suggested-action");

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

    calculateButton.OnClicked += (_, _) =>
    {
        var day = DayOfWeekParser.FromString(dayOfWeekStringList.GetString(dayOfWeekDropdown.Selected) ?? "monday");

        var firstChild = resultBox.GetFirstChild();
        if (firstChild != null)
        {
            resultBox.Remove(firstChild);
        }

        var result = Cost.Calculate((int)Math.Round(durationEntry.Value), day);
        var resultLabel = Gtk.Label.New($"{result}");
        resultBox.Append(resultLabel);
    };

    container.Append(resultBox);

    // Window
    var window = Gtk.ApplicationWindow.New((Adw.Application)sender);
    window.Title = "Parkeringsautomaten";
    window.SetDefaultSize(300, 500);
    window.SetChild(container);
    window.Show();
};
return application.RunWithSynchronizationContext(null);
