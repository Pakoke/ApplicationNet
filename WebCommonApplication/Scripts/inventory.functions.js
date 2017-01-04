DialogEdit = function (button) {
    
    EditValue(button);
}

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
        id: guid(),
        //url: '@(Url.Action("EditFromList", "Inventory"))',
        url: "Inventory/PostEditList",
        content: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify({ Make: $makedata, Model: $modeldata, Year: $yeardata } ),
        success: function (d) {
                alert(d);
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
        url: "Inventory/PostRemoveList",
        content: "application/json; charset=utf-8",
        dataType: "json",
        data: { Make: $makedata, Model: $modeldata, Year: $yeardata },
        success: function (d) {
           alert(d)
            
        },
        error: function (xhr, textStatus, errorThrown) {
            // TODO: Show error
        }
    });
    
};

function guid() {
    function s4() {
        return Math.floor((1 + Math.random()) * 0x10000)
          .toString(16)
          .substring(1);
    }
    return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
      s4() + '-' + s4() + s4() + s4();
}

