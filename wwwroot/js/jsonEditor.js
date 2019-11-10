var select_data_type = $('select[name="data-type"]');

$.each(select_data_type, function () {
    this.onchange = function () {

        // 取得父物件
        var parents = $(this).parent();
        var parent = $(this).parent().get(0);

        // 生成div區塊 或是取得 div區塊
        var contentDiv = null;
        if (!parents.children('div[name="data-content"]').length) {
            contentDiv = document.createElement("div");
            contentDiv.setAttribute("name", "data-content");
            parent.appendChild(contentDiv);
        }
        else {
            contentDiv = parents.children('div[name="data-content"]')[0];
        }
        //alert($(contentDiv).children('div[name="' + this.value + '"]').length);
        var content_detail = null;
        if (!$(contentDiv).children('div[name="' + this.value + '"]').length) {
            content_detail = document.createElement("div");
            content_detail.setAttribute("name", this.value);
            switch (this.value) {
                case "string":
                    var label = document.createElement("label");
                    label.className = "control-label";
                    label.innerHTML = "字串";
                    var input = document.createElement("input");
                    input.type = "text";
                    input.className = "form-control";
                    input.name = "date-value";
                    content_detail.appendChild(label);
                    content_detail.appendChild(input);
                    break;
                case "number":
                    var label = document.createElement("label");
                    label.className = "control-label";
                    label.innerHTML = "數字";
                    var input = document.createElement("input");
                    input.type = "number";
                    input.className = "form-control";
                    input.name = "date-value";
                    content_detail.appendChild(label);
                    content_detail.appendChild(input);
                    break;
                case "datetime":
                    var label = document.createElement("label");
                    label.className = "control-label datetimePicker";
                    label.innerHTML = "時間";
                    var input = document.createElement("input");
                    input.type = "datetime";
                    input.className = "form-control";
                    input.name = "date-value";
                    content_detail.appendChild(label);
                    content_detail.appendChild(input);
                    break;
                default:
                    alert("Nothing");
                    break;
            }
            contentDiv.appendChild(content_detail);
        }
        else {
        }
        $.each($(contentDiv).children('div'), function () {
            $(this).hide();
        });
        $($(contentDiv).children('div[name="' + this.value + '"]')[0]).show();
    }
});
$('#datetimepicker1').datetimepicker();