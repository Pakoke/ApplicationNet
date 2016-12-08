//window.onload = function () {
//    alert("welcome");
//};

EditValue = function (button) {
    //$(button).find("#button-edit").parent().parent().find("th[name*='data']");
    $tagsDatas = $(button).parent().parent().find("th[name*='data']");
    $makedata = null;
    $modeldata = null;
    $yeardata = null;
    for (var $tag in $tagsDatas.toArray()) {
        $object =$tagsDatas[$tag]
        if ($object.getAttribute("name").search("make") !== -1) {
            $makedata = $object.textContent;
        }
        if ($object.getAttribute("name").search("model") !== -1) {
            $modeldata = $object.textContent;
        }
        if ($object.getAttribute("name").search("year") !== -1) {
            $yeardata = $object.textContent;
        }
    }
    
    $.ajax({
        type: "POST",
        //url: '@(Url.Action("EditFromList", "Inventory"))',
        url: "Inventory/EditList",
        content: "application/json; charset=utf-8",
        dataType: "json",
        data: { Make: $makedata, Model: $modeldata, Year: $yeardata },
        success: function (d) {
            if (d.success == true)
                //alert(d);
                window.location = "index.html";
            else 
            {
                alert(d);
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
};

RemoveValue = function (button) {
    //$(button).find("#button-edit").parent().parent().find("th[name*='data']");
    $tagsDatas = $(button).parent().parent().find("th[name*='data']");
    $makedata = null;
    $modeldata = null;
    $yeardata = null;
    for (var $tag in $tagsDatas.toArray()) {
        $object = $tagsDatas[$tag]
        if ($object.getAttribute("name").search("make") !== -1) {
            $makedata = $object.textContent;
        }
        if ($object.getAttribute("name").search("model") !== -1) {
            $modeldata = $object.textContent;
        }
        if ($object.getAttribute("name").search("year") !== -1) {
            $yeardata = $object.textContent;
        }
    }

    //$.post("~/Inventory/EditFromList", { Make: $makedata, Model: $modeldata, Year: $yeardata }, function (data) {
    //    window.onload = function () {
    //        alert(data);
    //    };
    //});

    $.ajax({
        type: "POST",
        //url: '@(Url.Action("EditFromList", "Inventory"))',
        url: "Inventory/RemoveList",
        content: "application/json; charset=utf-8",
        dataType: "json",
        data: { Make: $makedata, Model: $modeldata, Year: $yeardata },
        success: function (d) {
            if (d.success == true)
                //alert(d);
                window.location = "index.html";
            else {
                alert(d);
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
    
};

