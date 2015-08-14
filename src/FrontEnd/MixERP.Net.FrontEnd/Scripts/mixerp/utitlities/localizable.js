/*
The HTML nodes having the data-localize attribute 
will be localized with their respective culture values.

For example:

<span data-localize="ScrudResource.company_name"></span>

will be converted to 

Company Name in English or
Firmenname in German
*/

var localizable = document.querySelectorAll("[data-localize]");

for (var i = 0; i < localizable.length; i++) {
    var localize = "Resources." + localizable[i].getAttribute("data-localize");
    var localized = executeFunctionByName(localize, window);

    if (localized) {
        localizable[i].innerHTML = localized;

        //Replace this node with the localized text.
        localizable[i].parentNode.insertBefore(localizable[i].firstChild, localizable[i]);
        localizable[i].parentNode.removeChild(localizable[i]);
    };
};
