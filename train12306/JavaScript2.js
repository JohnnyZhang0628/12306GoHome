var myJpopup;
var jPlayer; (function () {
    var b = "输入乘客姓名";
    var a = false;
    $(document).ready(function () {
        myJpopup = $("#any").jpopup({
            width: 350,
            height: 140,
            target: $("#getTicket"),
            speed: 20
        });
        var d;
        if (!window.attachEvent) {
            var c = audiojs;
            c.events.ready(function () {
                d = c.createAll()
            })
        }
        jPlayer = function (f) {
            $("#tryPlayer").html("停止提示音乐");
            if (f == "play") {
                if (window.attachEvent) {
                    $("#jplayerId").html('<embed type="application/x-mplayer2" loop="true" src="' + ctx + '/resources/js/framework/audio/message.wav" id="player" autostart="true" uiMode="none" hidden="true"></embed>')
                } else {
                    try {
                        d[0].play()
                    } catch (h) { }
                }
            } else {
                $("#tryPlayer").html("试听提示音乐");
                if (window.attachEvent) {
                    var g = document.getElementById("player");
                    try {
                        g.pause()
                    } catch (h) {
                        document.getElementById("jplayerId").innerHTML = ""
                    }
                } else {
                    try {
                        d[0].pause()
                    } catch (h) { }
                }
            }
        };
        $.init_select_date();
        $("#tryPlayer").click(function () {
            if ($(this).html() == "试听提示音乐") {
                jPlayer("play");
                $(this).html("停止提示音乐")
            } else {
                jPlayer("stop");
                $(this).html("试听提示音乐")
            }
        });
        $("#reloadPassenger").click(function () {
            $.reloadPassenger()
        });
        $("#searchPassenger").on("keyup",
            function (f) {
                $.renderPassenger()
            }).on("focus",
                function () {
                    if ($(this).val() == b) {
                        $(this).val("")
                    }
                }).on("blur",
                    function () {
                        if ($(this).val() == "") {
                            $(this).val(b)
                        }
                    });
        $("#inp-train").on("click",
            function (g) {
                var f = $("#inp-train").val();
                a = true;
                if ($.trim(f) == "请输入") {
                    $("#inp-train").val("");
                    $(this).css("color", "#000")
                } else {
                    $("#inp-train").select()
                }
            }).on("blur",
                function (f) {
                    if ($.trim($("#inp-train").val()) == "") {
                        $(this).css("color", "#999");
                        $("#inp-train").val("  请输入")
                    }
                });
        $("#seat-list li").click(function () {
            if ($(this).attr("disabled") == "disabled") {
                return
            }
            var h = $(this).attr("name");
            var g = $(this).attr("scode");
            var f = $("#prior_seat span").length;
            if (!$(this).hasClass("cur")) {
                if (f < 6) {
                    if ($.canSelectThisSeatType(g)) {
                        var e = "<span class='sel-box w80' name='" + h + "'>" + h + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + g + "\",2)'></a></span>";
                        $("#prior_seat").append(e);
                        xbChecked.push(g);
                        $(this).addClass("cur");
                        $.chooseAutoSubmit()
                    } else {
                        this.checked = false;
                        dhtmlx.alert({
                            title: "添加席别",
                            ok: "确定",
                            text: "学生不可以购买" + h + "。",
                            type: "alert-error"
                        })
                    }
                } else {
                    dhtmlx.alert({
                        title: "添加席别",
                        ok: "确定",
                        text: "最多添加5个优先席位",
                        type: "alert-error"
                    })
                }
            } else {
                $.each($("#prior_seat span"),
                    function (j, l) {
                        if (h == $(l).attr("name")) {
                            $(l).remove();
                            for (var k = 0; k < xbChecked.length; k++) {
                                if (xbChecked[k] == g) {
                                    xbChecked.splice(k, 1);
                                    break
                                }
                            }
                            return
                        }
                    });
                $(this).removeClass("cur")
            }
        });
        $("#date-list li").click(function () {
            if ($(this).attr("train_date") == "yes") {
                return
            }
            var h = $("#prior_date span").length;
            var j = $(this).attr("name");
            if (!$(this).hasClass("cur")) {
                if (h < 6) {
                    var e = "<span class='sel-box w80' name='" + j + "'>" + j + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + j + "\",3)'></a></span>";
                    $("#prior_date").append(e);
                    $(this).addClass("cur");
                    $.chooseAutoSubmit();
                    var f = true;
                    for (var g = 0; g < rqChecked.length; g++) {
                        if (rqChecked[g] == j) {
                            f = false;
                            break
                        }
                    }
                    if (f) {
                        rqChecked.push(j)
                    }
                } else {
                    dhtmlx.alert({
                        title: "添加备选日期",
                        ok: "确定",
                        text: "最多添加5个备选日期",
                        type: "alert-error"
                    });
                    $(this).removeClass("cur")
                }
            } else {
                $.each($("#prior_date span"),
                    function (k, m) {
                        if (j == $(m).attr("name")) {
                            $(m).remove();
                            for (var l = 0; l < rqChecked.length; l++) {
                                if (rqChecked[l] == j) {
                                    rqChecked.splice(l, 1);
                                    break
                                }
                            }
                            return
                        }
                    });
                if (train_tour_flag == "fc") {
                    if (j == $("#back_train_date").val()) {
                        rqChecked.splice(0, 1);
                        $("#back_train_date").val(rqChecked[0]);
                        $("#prior_date span[name=" + rqChecked[0] + "]").remove()
                    }
                } else {
                    if (j == $("#train_date").val()) {
                        rqChecked.splice(0, 1);
                        $("#train_date").val(rqChecked[0]);
                        $("#prior_date span[name=" + rqChecked[0] + "]").remove()
                    }
                }
                if (rqChecked.length == 1) {
                    $("#date-list input").attr("disabled", false);
                    $("#date-list input[value=" + rqChecked[0] + "]").attr("disabled", true)
                }
                $(this).removeClass("cur")
            }
        });
        $("#train_date").click(function () {
            $("#sel-date").hide()
        });
        $("#back_train_date").click(function () {
            $("#sel-date").hide()
        });
        if (!isInMaintenanceHours) {
            $("#dc").click(function () {
                $("#autoSubmit").removeAttr("disabled");
                $("#autoSubmit").siblings("label").css("color", "#333");
                $("#autoSubmitTxt").removeAttr("title");
                $("#partSubmit").removeAttr("disabled");
                $("#partSubmit").siblings("label").css("color", "#333");
                $("#partSubmitTxt").removeAttr("title")
            });
            $("#wf").click(function () {
                $("#autoSubmit").prop("checked", false);
                $("#autoSubmit").attr("disabled", true);
                $("#autoSubmit").siblings("label").css("color", "#999");
                $("#autoSubmitTxt").attr("title", "自动提交只能在单程下使用");
                $("#partSubmit").prop("checked", false);
                $("#partSubmit").attr("disabled", true);
                $("#partSubmit").siblings("label").css("color", "#999");
                $("#partSubmitTxt").attr("title", "部分提交只能在单程下使用")
            })
        }
        $("#sf2").click(function () {
            if (passengerChecked && passengerChecked.length > 0) {
                var l = passengerChecked.length;
                for (var h = l - 1; h >= 0; h--) {
                    var n = passengerChecked[h];
                    var j = n.passenger_type_name;
                    if (!j) {
                        j = ""
                    }
                    if (n.passenger_type != "3") {
                        var f = n.passenger_name + "(" + j + ")(" + n.passenger_id_no + ")";
                        var m = $("#buyer-list input");
                        var g = m.length;
                        for (var e = 0; e < g; e++) {
                            if ($(m[e]).attr("p_value") == f) {
                                m[e].checked = false
                            }
                        }
                        $("#setion_postion span[name='" + f + "']").remove();
                        passengerChecked.splice(h, 1)
                    }
                }
            }
        });
        $("#autoSubmit").click(function () {
            if (this.checked) {
                $("#auto_query").prop("checked", true)
            } else {
                $("#partSubmit").prop("checked", false)
            }
        });
        $("#partSubmit").click(function () {
            if (this.checked) {
                $("#autoSubmit").prop("checked", true);
                $("#auto_query").prop("checked", true)
            }
        });
        $("#auto_query").click(function () {
            if (!this.checked) {
                $("#autoSubmit").prop("checked", false)
            }
        });
        $("#clearAll").click(function () {
            $("#setion_postion span:gt(0)").remove();
            $("#buyer-list li").removeClass("cur");
            passengerChecked = [];
            $("#prior_train span:gt(1)").remove();
            $("#inp-train").css("color", "#999");
            $("#inp-train").val("  请输入");
            ccSelected = [];
            $("#prior_seat span:gt(0)").remove();
            $("#seat-list li").removeClass("cur");
            xbChecked = [];
            $("#prior_date span:gt(0)").remove();
            var f = rqChecked.length;
            for (var e = 1; e < f; e++) {
                $("#date-list li[name=" + rqChecked[e] + "]").removeClass("cur")
            }
            rqChecked.splice(1, f - 1);
            $("#autoSubmit").prop("checked", false);
            $("#partSubmit").prop("checked", false)
        });
        $("#autoSubmit").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick3").css({
                top: f,
                left: g
            });
            $("#showquick3").show()
        });
        $("#autoSubmit").mouseleave(function () {
            $("#showquick3").hide()
        });
        $("#partSubmit").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick2").css({
                top: f,
                left: g
            });
            $("#showquick2").show()
        });
        $("#partSubmit").mouseleave(function () {
            $("#showquick2").hide()
        });
        $("#auto_query").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick1").css({
                top: f,
                left: g - 96
            });
            $("#showquick1").show()
        });
        $("#auto_query").mouseleave(function () {
            $("#showquick1").hide()
        });
        $("#memb").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick4").css({
                top: f,
                left: g
            });
            $("#showquick4").show()
        });
        $("#memb").mouseleave(function () {
            $("#showquick4").hide()
        });
        $("#train_first").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick5").css({
                top: f,
                left: g
            });
            $("#showquick5").show()
        });
        $("#train_first").mouseleave(function () {
            $("#showquick5").hide()
        });
        $("#seat_first").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick6").css({
                top: f,
                left: g
            });
            $("#showquick6").show()
        });
        $("#seat_first").mouseleave(function () {
            $("#showquick6").hide()
        });
        $("#select_date").mouseenter(function (h) {
            var f = h.pageY + 10;
            var g = h.pageX;
            $("#showquick8").css({
                top: f,
                left: g
            });
            $("#showquick8").show()
        });
        $("#select_date").mouseleave(function () {
            $("#showquick8").hide()
        })
    });
    jQuery.extend({
        init_select_date: function () {
            if (otherDateArr.length < 5) {
                $("#sel-date>div:first").html('<a href="javascript:" onclick="$.closeSelectDate()" >关闭</a>选择日期');
                return
            }
        },
        checkedPasseanger: function (j) {
            if (passengerAll) {
                var l = passengerAll.length;
                for (var g = 0; g < l; g++) {
                    var e = passengerAll[g];
                    var c = e.passenger_type_name;
                    if (!c) {
                        c = ""
                    }
                    var i = e.passenger_name + "(" + c + ")(" + e.passenger_id_no + ")";
                    if (i == j) {
                        passengerChecked.push(e);
                        break
                    }
                    var f = e.passenger_name + "(儿童)(" + e.passenger_id_no + ")";
                    if (f == j) {
                        var h = $.extend(true, {},
                            e);
                        h.passenger_type_name = "儿童";
                        h.passenger_type = 2;
                        passengerChecked.push(h);
                        break
                    }
                    if (e.passenger_type == ticket_submit_order.ticket_type.student && j.indexOf("成人") > -1) {
                        var d = e.passenger_name + "(成人)(" + e.passenger_id_no + ")";
                        if (d == j) {
                            var h = $.extend(true, {},
                                e);
                            h.passenger_type_name = "成人";
                            h.passenger_type = ticket_submit_order.ticket_type.adult;
                            passengerChecked.push(h);
                            break
                        }
                    }
                }
            }
        },
        removePasseanger: function (h) {
            if (passengerChecked && passengerChecked.length > 0) {
                var e = passengerChecked.length;
                for (var d = 0; d < e; d++) {
                    var g = passengerChecked[d];
                    var f = g.passenger_type_name;
                    if (!f) {
                        f = ""
                    }
                    var c = g.passenger_name + "(" + f + ")(" + g.passenger_id_no + ")";
                    if (c == h) {
                        passengerChecked.splice(d, 1);
                        break
                    }
                }
            }
        },
        addChildPassenger: function (e) {
            var d = $("#setion_postion span").length;
            if (d < 6) {
                e = e.split("(")[0] + "(儿童)(" + e.split("(")[2];
                var c = "<span name='" + e + "' class='sel-box w80'>" + e + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + e + "\",1)'></a></span>";
                $("#setion_postion").append(c);
                $.checkedPasseanger(e)
            } else {
                dhtmlx.alert({
                    title: "添加常用联系人",
                    ok: "确定",
                    text: "最多添加5位联系人",
                    type: "alert-error"
                });
                return
            }
        },
        closeSelectBuyer: function () {
            $("#sel-buyer").hide()
        },
        showSelectSeat: function () {
            var c = [];
            var n = [];
            var l = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
            var d = [0, 1, 2, 3, 7, 8];
            var e = [0, 1, 2, 3, 5, 10, 11];
            var j = [4, 5, 6, 9, 10, 11];
            var m = true;
            var p = true;
            var o = ccSelected.length;
            if (o > 0) {
                for (var g = 0; g < o; g++) {
                    var i = ccSelected[g].substr(0, 1);
                    if (m) {
                        if (i == "C" || i == "G" || i == "S" || i == "D") {
                            if (p) {
                                if (i == "D") {
                                    c = e
                                } else {
                                    c = d
                                }
                            } else {
                                c = l
                            }
                            m = false
                        }
                    } else {
                        if (i == "D") {
                            c = e
                        }
                    }
                    if (p) {
                        var h = Number(i);
                        if (i == "T" || i == "K" || i == "Z" || i == "L" || i == "A" || (h && h >= 0 && h <= 9)) {
                            if (m) {
                                c = j
                            } else {
                                c = l
                            }
                            p = false
                        }
                    }
                }
                if ((m && p) || (!m && !p)) {
                    c = l
                } else {
                    if (m && !p) {
                        n = d
                    } else {
                        if (!m && p) {
                            n = j
                        }
                    }
                }
            } else {
                c = l
            }
            var f = $("#seat-list li");
            for (var g = 0; g < n.length; g++) {
                f.eq(n[g]).attr("disabled", "disabled");
                $(f.eq(n[g])).addClass("color999")
            }
            for (var g = 0; g < c.length; g++) {
                f.eq(c[g]).removeAttr("disabled");
                f.eq(c[g]).removeClass("color999")
            }
            $("#sel-seat").show();
            $("#sel-buyer").hide();
            $("#sel-date").hide();
            $("#yxtraindiv").hide();
            $("#sel-seat").css("left", $("#sear-sel").position().left + 80);
            $("#sel-seat").css("top", $("#sear-sel").position().top + 6 * 28 + 12)
        },
        closeSelectSeat: function () {
            $("#sel-seat").hide()
        },
        showSelectDate: function () {
            $("#date-list li[train_date='yes']").removeClass("cur");
            $("#sel-date").show();
            var e = $("#train_date").val();
            $("#date-list li").removeAttr("train_date").removeClass("cur");
            $("#date-list li[name=" + e + "]").addClass("cur").attr("train_date", "yes");
            var d = $("#prior_date span:gt(0)");
            for (var c = 0; c < d.length; c++) {
                var f = $(d[c]).attr("name");
                $("#date-list li[name=" + f + "]").addClass("cur")
            }
            $("#sel-buyer").hide();
            $("#sel-seat").hide();
            $("#yxtraindiv").hide();
            $("#sel-date").css("left", $("#sear-sel").position().left + 80);
            $("#sel-date").css("top", $("#sear-sel").position().top + 7 * 28 + 12)
        },
        closeSelectDate: function () {
            $("#sel-date").hide()
        },
        removeSel: function (h, j, c) {
            $(h).parent().remove();
            if ("1" == c) {
                var g = $("#buyer-list li");
                var f = g.length;
                for (var d = 0; d < f; d++) {
                    if ($(g[d]).attr("p_value") == j) {
                        $(g[d]).removeClass("cur")
                    }
                }
                $.removePasseanger(j)
            } else {
                if ("2" == c) {
                    var g = $("#seat-list li");
                    var f = g.length;
                    for (var d = 0; d < f; d++) {
                        if ($(g[d]).attr("scode") == j) {
                            $(g[d]).removeClass("cur");
                            for (var e = 0; e < xbChecked.length; e++) {
                                if (xbChecked[e] == j) {
                                    xbChecked.splice(e, 1);
                                    return
                                }
                            }
                        }
                    }
                } else {
                    if ("3" == c) {
                        var g = $("#date-list li");
                        var f = g.length;
                        for (var d = 0; d < f; d++) {
                            if ($(g[d]).attr("name") == j) {
                                $(g[d]).removeClass("cur");
                                for (var e = 0; e < rqChecked.length; e++) {
                                    if (rqChecked[e] == j) {
                                        rqChecked.splice(e, 1);
                                        return
                                    }
                                }
                            }
                        }
                    } else {
                        if ("4" == c) {
                            $("#yxtrain_code li[traincode=" + j + "]").removeClass();
                            for (var e = 0; e < ccSelected.length; e++) {
                                if (ccSelected[e] == j) {
                                    ccSelected.splice(e, 1);
                                    return
                                }
                            }
                        }
                    }
                }
            }
        }
    });
    jQuery.extend({
        checkTrain: function (f, d) {
            if (a) {
                $(d).val("")
            }
            a = false;
            var c = window.event ? f.keyCode : f.which;
            if ("" == $(d).val()) {
                if (!(((c >= 48) && (c <= 57)) || (c == 67 || c == 71 || c == 68 || c == 84 || c == 75 || c == 89 || c == 76 || c == 65 || c == 83 || c == 90) || (c == 99 || c == 103 || c == 100 || c == 116 || c == 107 || c == 121 || c == 108 || c == 97 || c == 115 || c == 122) || c == 8 || c == 0)) {
                    if (window.event) {
                        window.event.returnValue = false
                    } else {
                        f.preventDefault()
                    }
                }
            } else {
                if (!(((c >= 48) && (c <= 57)) || c == 8 || c == 0)) {
                    if (window.event) {
                        window.event.returnValue = false
                    } else {
                        f.preventDefault()
                    }
                }
            }
        }
    })
})();
var ticket_submit_order = {
    ticket_type: {
        adult: "1",
        child: "2",
        student: "3",
        disability: "4"
    },
    ticket_type_name: {
        "1": "成人票",
        "2": "孩票",
        "3": "学生票",
        "4": "伤残军人票"
    },
    tour_flag: {
        dc: "dc",
        wc: "wc",
        fc: "fc",
        gc: "gc",
        lc: "lc",
        lc1: "l1",
        lc2: "l2"
    },
    passenger_type: {
        adult: "1",
        child: "2",
        student: "3",
        disability: "4"
    },
    passenger_card_type: {
        two: "1",
        one: "2",
        tmp: "3",
        passport: "B",
        work: "H",
        hongkong_macau: "C",
        taiwan: "G"
    },
    request_flag: {
        isAsync: "1"
    },
    ticket_query_flag: {
        query_commom: "00",
        query_student: "0X00"
    },
    seatType: {
        yz_type: "1"
    },
    ref_res_rules: {
        "4": [{
            refund_rule: "20%",
            res_rule: "免费",
            title: "bt_15d"
        },
        {
            refund_rule: "30%",
            res_rule: "5%",
            title: "48h_15d"
        },
        {
            refund_rule: "50%",
            res_rule: "10%",
            title: "24h_48H"
        },
        {
            refund_rule: "不允许",
            res_rule: "20%",
            title: "lt_24h"
        }],
        "5": [{
            refund_rule: "10%",
            res_rule: "免费",
            title: "bt_15d"
        },
        {
            refund_rule: "15%",
            res_rule: "5%",
            title: "48h_15d"
        },
        {
            refund_rule: "25%",
            res_rule: "10%",
            title: "24h_48H"
        },
        {
            refund_rule: "40%",
            res_rule: "20%",
            title: "lt_24h"
        }],
        "6": [{
            refund_rule: "10%",
            res_rule: "免费",
            title: "bt_15d"
        },
        {
            refund_rule: "15%",
            res_rule: "5%",
            title: "48h_15d"
        },
        {
            refund_rule: "25%",
            res_rule: "10%",
            title: "24h_48H"
        },
        {
            refund_rule: "40%",
            res_rule: "20%",
            title: "lt_24h"
        }],
        "7": [{
            refund_rule: "5%",
            res_rule: "免费",
            title: "bt_15d"
        },
        {
            refund_rule: "10%",
            res_rule: "5%",
            title: "48h_15d"
        },
        {
            refund_rule: "15%",
            res_rule: "10%",
            title: "24h_48H"
        },
        {
            refund_rule: "30%",
            res_rule: "20%",
            title: "lt_24h"
        }],
        "8": [{
            refund_rule: "5%",
            res_rule: "免费",
            title: "bt_15d"
        },
        {
            refund_rule: "10%",
            res_rule: "5%",
            title: "48h_15d"
        },
        {
            refund_rule: "15%",
            res_rule: "10%",
            title: "24h_48H"
        },
        {
            refund_rule: "30%",
            res_rule: "20%",
            title: "lt_24h"
        }],
        "9": [{
            refund_rule: "免费",
            res_rule: "免费",
            title: "bt_15d"
        },
        {
            refund_rule: "5%",
            res_rule: "5%",
            title: "48h_15d"
        },
        {
            refund_rule: "10%",
            res_rule: "10%",
            title: "24h_48H"
        },
        {
            refund_rule: "20%",
            res_rule: "20%",
            title: "lt_24h"
        }]
    },
    special_areas: {
        lso: "LSO",
        dao: "DAO",
        ado: "ADO",
        nqo: "NQO",
        tho: "THO"
    }
};
function OrderQueueWaitTime(a, c, b) {
    this.tourFlag = a;
    this.waitMethod = c;
    this.finishMethod = b;
    this.dispTime = 1;
    this.nextRequestTime = 1;
    this.isFinished = false;
    this.waitObj
}
OrderQueueWaitTime.prototype.start = function (a) {
    if (!a) {
        a = 1000
    }
    var b = this;
    b.timerJob();
    window.setInterval(function () {
        b.timerJob()
    },
        parseInt(a))
};
OrderQueueWaitTime.prototype.timerJob = function () {
    if (this.isFinished) {
        return
    }
    if (this.dispTime <= 0) {
        this.isFinished = true;
        this.finishMethod(this.tourFlag, this.dispTime, this.waitObj);
        return
    }
    if (this.dispTime == this.nextRequestTime) {
        this.getWaitTime()
    }
    var a = this.dispTime;
    var c = "";
    var b = parseInt(a / 60);
    if (b >= 1) {
        c = b + "分";
        a = a % 60
    } else {
        c = "1分"
    }
    this.waitMethod(this.tourFlag, this.dispTime > 1 ? --this.dispTime : 1, c)
};
OrderQueueWaitTime.prototype.getWaitTime = function () {
    var a = this;
    $.ajax({
        url: ctx + "confirmPassenger/queryOrderWaitTime?random=" + new Date().getTime(),
        type: "GET",
        data: {
            tourFlag: a.tourFlag
        },
        dataType: "json",
        success: function (c) {
            var e = c.data;
            if (!e.queryOrderWaitTimeStatus) {
                window.location.href = ctx + "view/index.html?random=" + new Date().getTime()
            } else {
                if (e != null) {
                    a.waitObj = e;
                    if (e.waitTime != -100) {
                        a.dispTime = e.waitTime;
                        var d = parseInt(e.waitTime / 1.5);
                        d = d > 60 ? 60 : d;
                        var b = e.waitTime - d;
                        a.nextRequestTime = b <= 0 ? 1 : b
                    }
                }
            }
        },
        error: function (b, d, c) {
            return false
        }
    })
};
var defaultLoadGrayBackgroundModalbox = "";
var loadGrayBackground;
var unLoadGrayBackground; (function () {
    loadGrayBackground = function () {
        var a = dhtmlx.modalbox({
            targSrc: '<div><img src="' + ctx + 'resources/images/loading.gif"></img></div>',
            callback: function () { }
        });
        defaultLoadGrayBackgroundModalbox = a
    };
    unLoadGrayBackground = function () {
        if (defaultLoadGrayBackgroundModalbox != "") {
            dhtmlx.modalbox.hide(defaultLoadGrayBackgroundModalbox);
            defaultLoadGrayBackgroundModalbox = ""
        }
    }
})(); (function (b, e, c) {
    var d = function () {
        for (var f = /audio(.min)?.js.*/,
            g = document.getElementsByTagName("script"), j = 0, i = g.length; j < i; j++) {
            var h = g[j].getAttribute("src");
            if (f.test(h)) {
                return h.replace(f, "")
            }
        }
    }();
    c[b] = {
        instanceCount: 0,
        instances: {},
        flashSource: '      <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" id="$1" width="1" height="1" name="$1" style="position: absolute; left: -1px;">         <param name="movie" value="$2?playerInstance=' + b + '.instances[\'$1\']&datetime=$3">         <param name="allowscriptaccess" value="always">         <embed name="$1" src="$2?playerInstance=' + b + '.instances[\'$1\']&datetime=$3" width="1" height="1" allowscriptaccess="always">       </object>',
        settings: {
            autoplay: false,
            loop: false,
            preload: true,
            imageLocation: d + "player-graphics.gif",
            swfLocation: d + "audiojs.swf",
            useFlash: function () {
                var f = document.createElement("audio");
                return !(f.canPlayType && f.canPlayType("audio/mpeg;").replace(/no/, ""))
            }(),
            hasFlash: function () {
                if (navigator.plugins && navigator.plugins.length && navigator.plugins["Shockwave Flash"]) {
                    return true
                } else {
                    if (navigator.mimeTypes && navigator.mimeTypes.length) {
                        var f = navigator.mimeTypes["application/x-shockwave-flash"];
                        return f && f.enabledPlugin
                    } else {
                        try {
                            new ActiveXObject("ShockwaveFlash.ShockwaveFlash");
                            return true
                        } catch (g) { }
                    }
                }
                return false
            }(),
            createPlayer: {
                markup: '          <div class="play-pause">             <p class="play"></p>             <p class="pause"></p>             <p class="loading"></p>             <p class="error"></p>           </div>           <div class="scrubber">             <div class="progress"></div>             <div class="loaded"></div>           </div>           <div class="time">             <em class="played">00:00</em>/<strong class="duration">00:00</strong>           </div>           <div class="error-message"></div>',
                playPauseClass: "play-pause",
                scrubberClass: "scrubber",
                progressClass: "progress",
                loaderClass: "loaded",
                timeClass: "time",
                durationClass: "duration",
                playedClass: "played",
                errorMessageClass: "error-message",
                playingClass: "playing",
                loadingClass: "loading",
                errorClass: "error"
            },
            css: '        .audiojs audio { position: absolute; left: -1px; }         .audiojs { width: 460px; height: 36px; background: #404040; overflow: hidden; font-family: monospace; font-size: 12px;           background-image: -webkit-gradient(linear, left top, left bottom, color-stop(0, #444), color-stop(0.5, #555), color-stop(0.51, #444), color-stop(1, #444));           background-image: -moz-linear-gradient(center top, #444 0%, #555 50%, #444 51%, #444 100%);           -webkit-box-shadow: 1px 1px 8px rgba(0, 0, 0, 0.3); -moz-box-shadow: 1px 1px 8px rgba(0, 0, 0, 0.3);           -o-box-shadow: 1px 1px 8px rgba(0, 0, 0, 0.3); box-shadow: 1px 1px 8px rgba(0, 0, 0, 0.3); }         .audiojs .play-pause { width: 25px; height: 40px; padding: 4px 6px; margin: 0px; float: left; overflow: hidden; border-right: 1px solid #000; }         .audiojs p { display: none; width: 25px; height: 40px; margin: 0px; cursor: pointer; }         .audiojs .play { display: block; }         .audiojs .scrubber { position: relative; float: left; width: 280px; background: #5a5a5a; height: 14px; margin: 10px; border-top: 1px solid #3f3f3f; border-left: 0px; border-bottom: 0px; overflow: hidden; }         .audiojs .progress { position: absolute; top: 0px; left: 0px; height: 14px; width: 0px; background: #ccc; z-index: 1;           background-image: -webkit-gradient(linear, left top, left bottom, color-stop(0, #ccc), color-stop(0.5, #ddd), color-stop(0.51, #ccc), color-stop(1, #ccc));           background-image: -moz-linear-gradient(center top, #ccc 0%, #ddd 50%, #ccc 51%, #ccc 100%); }         .audiojs .loaded { position: absolute; top: 0px; left: 0px; height: 14px; width: 0px; background: #000;           background-image: -webkit-gradient(linear, left top, left bottom, color-stop(0, #222), color-stop(0.5, #333), color-stop(0.51, #222), color-stop(1, #222));           background-image: -moz-linear-gradient(center top, #222 0%, #333 50%, #222 51%, #222 100%); }         .audiojs .time { float: left; height: 36px; line-height: 36px; margin: 0px 0px 0px 6px; padding: 0px 6px 0px 12px; border-left: 1px solid #000; color: #ddd; text-shadow: 1px 1px 0px rgba(0, 0, 0, 0.5); }         .audiojs .time em { padding: 0px 2px 0px 0px; color: #f9f9f9; font-style: normal; }         .audiojs .time strong { padding: 0px 0px 0px 2px; font-weight: normal; }         .audiojs .error-message { float: left; display: none; margin: 0px 10px; height: 36px; width: 400px; overflow: hidden; line-height: 36px; white-space: nowrap; color: #fff;           text-overflow: ellipsis; -o-text-overflow: ellipsis; -icab-text-overflow: ellipsis; -khtml-text-overflow: ellipsis; -moz-text-overflow: ellipsis; -webkit-text-overflow: ellipsis; }         .audiojs .error-message a { color: #eee; text-decoration: none; padding-bottom: 1px; border-bottom: 1px solid #999; white-space: wrap; }                 .audiojs .play { background: url("$1") -2px -1px no-repeat; }         .audiojs .loading { background: url("$1") -2px -31px no-repeat; }         .audiojs .error { background: url("$1") -2px -61px no-repeat; }         .audiojs .pause { background: url("$1") -2px -91px no-repeat; }                 .playing .play, .playing .loading, .playing .error { display: none; }         .playing .pause { display: block; }                 .loading .play, .loading .pause, .loading .error { display: none; }         .loading .loading { display: block; }                 .error .time, .error .play, .error .pause, .error .scrubber, .error .loading { display: none; }         .error .error { display: block; }         .error .play-pause p { cursor: auto; }         .error .error-message { display: block; }',
            trackEnded: function () { },
            flashError: function () {
                var f = this.settings.createPlayer,
                    g = a(f.errorMessageClass, this.wrapper),
                    h = 'Missing <a href="http://get.adobe.com/flashplayer/">flash player</a> plugin.';
                if (this.mp3) {
                    h += ' <a href="' + this.mp3 + '">Download audio file</a>.'
                }
                c[b].helpers.removeClass(this.wrapper, f.loadingClass);
                c[b].helpers.addClass(this.wrapper, f.errorClass);
                g.innerHTML = h
            },
            loadError: function () {
                var f = this.settings.createPlayer,
                    g = a(f.errorMessageClass, this.wrapper);
                c[b].helpers.removeClass(this.wrapper, f.loadingClass);
                c[b].helpers.addClass(this.wrapper, f.errorClass);
                g.innerHTML = 'Error loading: "' + this.mp3 + '"'
            },
            init: function () {
                c[b].helpers.addClass(this.wrapper, this.settings.createPlayer.loadingClass)
            },
            loadStarted: function () {
                var f = this.settings.createPlayer,
                    g = a(f.durationClass, this.wrapper),
                    i = Math.floor(this.duration / 60),
                    h = Math.floor(this.duration % 60);
                c[b].helpers.removeClass(this.wrapper, f.loadingClass);
                g.innerHTML = (i < 10 ? "0" : "") + i + ":" + (h < 10 ? "0" : "") + h
            },
            loadProgress: function (f) {
                var g = this.settings.createPlayer,
                    h = a(g.scrubberClass, this.wrapper);
                a(g.loaderClass, this.wrapper).style.width = h.offsetWidth * f + "px"
            },
            playPause: function () {
                this.playing ? this.settings.play() : this.settings.pause()
            },
            play: function () {
                c[b].helpers.addClass(this.wrapper, this.settings.createPlayer.playingClass)
            },
            pause: function () {
                c[b].helpers.removeClass(this.wrapper, this.settings.createPlayer.playingClass)
            },
            updatePlayhead: function (f) {
                var g = this.settings.createPlayer,
                    h = a(g.scrubberClass, this.wrapper);
                a(g.progressClass, this.wrapper).style.width = h.offsetWidth * f + "px";
                g = a(g.playedClass, this.wrapper);
                h = this.duration * f;
                f = Math.floor(h / 60);
                h = Math.floor(h % 60);
                g.innerHTML = (f < 10 ? "0" : "") + f + ":" + (h < 10 ? "0" : "") + h
            }
        },
        create: function (f, g) {
            g = g || {};
            return f.length ? this.createAll(g, f) : this.newInstance(f, g)
        },
        createAll: function (f, g) {
            var l = g || document.getElementsByTagName("audio"),
                k = [];
            f = f || {};
            for (var j = 0,
                h = l.length; j < h; j++) {
                k.push(this.newInstance(l[j], f))
            }
            return k
        },
        newInstance: function (f, g) {
            var j = this.helpers.clone(this.settings),
                i = "audiojs" + this.instanceCount,
                h = "audiojs_wrapper" + this.instanceCount;
            this.instanceCount++;
            if (f.getAttribute("autoplay") != null) {
                j.autoplay = true
            }
            if (f.getAttribute("loop") != null) {
                j.loop = true
            }
            if (f.getAttribute("preload") == "none") {
                j.preload = false
            }
            g && this.helpers.merge(j, g);
            if (j.createPlayer.markup) {
                f = this.createPlayer(f, j.createPlayer, h)
            } else {
                f.parentNode.setAttribute("id", h)
            }
            h = new c[e](f, j);
            j.css && this.helpers.injectCss(h, j.css);
            if (j.useFlash && j.hasFlash) {
                this.injectFlash(h, i);
                this.attachFlashEvents(h.wrapper, h)
            } else {
                j.useFlash && !j.hasFlash && this.settings.flashError.apply(h)
            }
            if (!j.useFlash || j.useFlash && j.hasFlash) {
                this.attachEvents(h.wrapper, h)
            }
            return this.instances[i] = h
        },
        createPlayer: function (f, g, j) {
            var i = document.createElement("div"),
                h = f.cloneNode(true);
            i.setAttribute("class", "audiojs");
            i.setAttribute("className", "audiojs");
            i.setAttribute("id", j);
            if (h.outerHTML && !document.createElement("audio").canPlayType) {
                h = this.helpers.cloneHtml5Node(f);
                i.innerHTML = g.markup;
                i.appendChild(h);
                f.outerHTML = i.outerHTML;
                i = document.getElementById(j)
            } else {
                i.appendChild(h);
                i.innerHTML += g.markup;
                f.parentNode.replaceChild(i, f)
            }
            return i.getElementsByTagName("audio")[0]
        },
        attachEvents: function (f, g) {
            if (g.settings.createPlayer) {
                var j = g.settings.createPlayer,
                    i = a(j.playPauseClass, f),
                    h = a(j.scrubberClass, f);
                c[b].events.addListener(i, "click",
                    function () {
                        g.playPause.apply(g)
                    });
                c[b].events.addListener(h, "click",
                    function (m) {
                        m = m.clientX;
                        var n = this,
                            l = 0;
                        if (n.offsetParent) {
                            do {
                                l += n.offsetLeft
                            } while (n = n.offsetParent)
                        }
                        g.skipTo((m - l) / h.offsetWidth)
                    });
                if (!g.settings.useFlash) {
                    c[b].events.trackLoadProgress(g);
                    c[b].events.addListener(g.element, "timeupdate",
                        function () {
                            g.updatePlayhead.apply(g)
                        });
                    c[b].events.addListener(g.element, "ended",
                        function () {
                            g.trackEnded.apply(g)
                        });
                    c[b].events.addListener(g.source, "error",
                        function () {
                            clearInterval(g.readyTimer);
                            clearInterval(g.loadTimer);
                            g.settings.loadError.apply(g)
                        })
                }
            }
        },
        attachFlashEvents: function (f, g) {
            g.swfReady = false;
            g.load = function (h) {
                g.mp3 = h;
                g.swfReady && g.element.load(h)
            };
            g.loadProgress = function (i, h) {
                g.loadedPercent = i;
                g.duration = h;
                g.settings.loadStarted.apply(g);
                g.settings.loadProgress.apply(g, [i])
            };
            g.skipTo = function (h) {
                if (!(h > g.loadedPercent)) {
                    g.updatePlayhead.call(g, [h]);
                    g.element.skipTo(h)
                }
            };
            g.updatePlayhead = function (h) {
                g.settings.updatePlayhead.apply(g, [h])
            };
            g.play = function () {
                if (!g.settings.preload) {
                    g.settings.preload = true;
                    g.element.init(g.mp3)
                }
                g.playing = true;
                g.element.pplay();
                g.settings.play.apply(g)
            };
            g.pause = function () {
                g.playing = false;
                g.element.ppause();
                g.settings.pause.apply(g)
            };
            g.setVolume = function (h) {
                g.element.setVolume(h)
            };
            g.loadStarted = function () {
                g.swfReady = true;
                g.settings.preload && g.element.init(g.mp3);
                g.settings.autoplay && g.play.apply(g)
            }
        },
        injectFlash: function (f, g) {
            var j = this.flashSource.replace(/\$1/g, g);
            j = j.replace(/\$2/g, f.settings.swfLocation);
            j = j.replace(/\$3/g, +new Date + Math.random());
            var i = f.wrapper.innerHTML,
                h = document.createElement("div");
            h.innerHTML = j + i;
            f.wrapper.innerHTML = h.innerHTML;
            f.element = this.helpers.getSwf(g)
        },
        helpers: {
            merge: function (f, g) {
                for (attr in g) {
                    if (f.hasOwnProperty(attr) || g.hasOwnProperty(attr)) {
                        f[attr] = g[attr]
                    }
                }
            },
            clone: function (f) {
                if (f == null || typeof f !== "object") {
                    return f
                }
                var g = new f.constructor,
                    h;
                for (h in f) {
                    g[h] = arguments.callee(f[h])
                }
                return g
            },
            addClass: function (f, g) {
                RegExp("(\\s|^)" + g + "(\\s|$)").test(f.className) || (f.className += " " + g)
            },
            removeClass: function (f, g) {
                f.className = f.className.replace(RegExp("(\\s|^)" + g + "(\\s|$)"), " ")
            },
            injectCss: function (g, h) {
                for (var p = "",
                    o = document.getElementsByTagName("style"), n = h.replace(/\$1/g, g.settings.imageLocation), l = 0, m = o.length; l < m; l++) {
                    var j = o[l].getAttribute("title");
                    if (j && ~j.indexOf("audiojs")) {
                        m = o[l];
                        if (m.innerHTML === n) {
                            return
                        }
                        p = m.innerHTML;
                        break
                    }
                }
                o = document.getElementsByTagName("head")[0];
                l = o.firstChild;
                m = document.createElement("style");
                if (o) {
                    m.setAttribute("type", "text/css");
                    m.setAttribute("title", "audiojs");
                    if (m.styleSheet) {
                        m.styleSheet.cssText = p + n
                    } else {
                        m.appendChild(document.createTextNode(p + n))
                    }
                    l ? o.insertBefore(m, l) : o.appendChild(styleElement)
                }
            },
            cloneHtml5Node: function (f) {
                var g = document.createDocumentFragment(),
                    h = g.createElement ? g : document;
                h.createElement("audio");
                h = h.createElement("div");
                g.appendChild(h);
                h.innerHTML = f.outerHTML;
                return h.firstChild
            },
            getSwf: function (f) {
                f = document[f] || window[f];
                return f.length > 1 ? f[f.length - 1] : f
            }
        },
        events: {
            memoryLeaking: false,
            listeners: [],
            addListener: function (f, g, h) {
                if (f.addEventListener) {
                    f.addEventListener(g, h, false)
                } else {
                    if (f.attachEvent) {
                        this.listeners.push(f);
                        if (!this.memoryLeaking) {
                            window.attachEvent("onunload",
                                function () {
                                    if (this.listeners) {
                                        for (var j = 0,
                                            i = this.listeners.length; j < i; j++) {
                                            c[b].events.purge(this.listeners[j])
                                        }
                                    }
                                });
                            this.memoryLeaking = true
                        }
                        f.attachEvent("on" + g,
                            function () {
                                h.call(f, window.event)
                            })
                    }
                }
            },
            trackLoadProgress: function (f) {
                if (f.settings.preload) {
                    var g, i;
                    f = f;
                    var h = /(ipod|iphone|ipad)/i.test(navigator.userAgent);
                    g = setInterval(function () {
                        if (f.element.readyState > -1) {
                            h || f.init.apply(f)
                        }
                        if (f.element.readyState > 1) {
                            f.settings.autoplay && f.play.apply(f);
                            clearInterval(g);
                            i = setInterval(function () {
                                f.loadProgress.apply(f);
                                f.loadedPercent >= 1 && clearInterval(i)
                            })
                        }
                    },
                        10);
                    f.readyTimer = g;
                    f.loadTimer = i
                }
            },
            purge: function (f) {
                var g = f.attributes,
                    h;
                if (g) {
                    for (h = 0; h < g.length; h += 1) {
                        if (typeof f[g[h].name] === "function") {
                            f[g[h].name] = null
                        }
                    }
                }
                if (g = f.childNodes) {
                    for (h = 0; h < g.length; h += 1) {
                        purge(f.childNodes[h])
                    }
                }
            },
            ready: function () {
                return function (w) {
                    var x = window,
                        v = false,
                        u = true,
                        t = x.document,
                        p = t.documentElement,
                        s = t.addEventListener ? "addEventListener" : "attachEvent",
                        o = t.addEventListener ? "removeEventListener" : "detachEvent",
                        j = t.addEventListener ? "" : "on",
                        l = function (f) {
                            if (!(f.type == "readystatechange" && t.readyState != "complete")) {
                            (f.type == "load" ? x : t)[o](j + f.type, l, false);
                                if (!v && (v = true)) {
                                    w.call(x, f.type || f)
                                }
                            }
                        },
                        h = function () {
                            try {
                                p.doScroll("left")
                            } catch (f) {
                                setTimeout(h, 50);
                                return
                            }
                            l("poll")
                        };
                    if (t.readyState == "complete") {
                        w.call(x, "lazy")
                    } else {
                        if (t.createEventObject && p.doScroll) {
                            try {
                                u = !x.frameElement
                            } catch (g) { }
                            u && h()
                        }
                        t[s](j + "DOMContentLoaded", l, false);
                        t[s](j + "readystatechange", l, false);
                        x[s](j + "load", l, false)
                    }
                }
            }()
        }
    };
    c[e] = function (f, g) {
        this.element = f;
        this.wrapper = f.parentNode;
        this.source = f.getElementsByTagName("source")[0] || f;
        this.mp3 = function (i) {
            var h = i.getElementsByTagName("source")[0];
            return i.getAttribute("src") || (h ? h.getAttribute("src") : null)
        }(f);
        this.settings = g;
        this.loadStartedCalled = false;
        this.loadedPercent = 0;
        this.duration = 1;
        this.playing = false
    };
    c[e].prototype = {
        updatePlayhead: function () {
            this.settings.updatePlayhead.apply(this, [this.element.currentTime / this.duration])
        },
        skipTo: function (f) {
            if (!(f > this.loadedPercent)) {
                this.element.currentTime = this.duration * f;
                this.updatePlayhead()
            }
        },
        load: function (f) {
            this.loadStartedCalled = false;
            this.source.setAttribute("src", f);
            this.element.load();
            this.mp3 = f;
            c[b].events.trackLoadProgress(this)
        },
        loadError: function () {
            this.settings.loadError.apply(this)
        },
        init: function () {
            this.settings.init.apply(this)
        },
        loadStarted: function () {
            if (!this.element.duration) {
                return false
            }
            this.duration = this.element.duration;
            this.updatePlayhead();
            this.settings.loadStarted.apply(this)
        },
        loadProgress: function () {
            if (this.element.buffered != null && this.element.buffered.length) {
                if (!this.loadStartedCalled) {
                    this.loadStartedCalled = this.loadStarted()
                }
                this.loadedPercent = this.element.buffered.end(this.element.buffered.length - 1) / this.duration;
                this.settings.loadProgress.apply(this, [this.loadedPercent])
            }
        },
        playPause: function () {
            this.playing ? this.pause() : this.play()
        },
        play: function () {
            / (ipod | iphone | ipad) / i.test(navigator.userAgent) && this.element.readyState == 0 && this.init.apply(this);
            if (!this.settings.preload) {
                this.settings.preload = true;
                this.element.setAttribute("preload", "auto");
                c[b].events.trackLoadProgress(this)
            }
            this.playing = true;
            this.element.play();
            this.settings.play.apply(this)
        },
        pause: function () {
            this.playing = false;
            this.element.pause();
            this.settings.pause.apply(this)
        },
        setVolume: function (f) {
            this.element.volume = f
        },
        trackEnded: function () {
            this.skipTo.apply(this, [0]);
            this.settings.loop || this.pause.apply(this);
            this.settings.trackEnded.apply(this)
        }
    };
    var a = function (g, h) {
        var n = [];
        h = h || document;
        if (h.getElementsByClassName) {
            n = h.getElementsByClassName(g)
        } else {
            var m, l, j = h.getElementsByTagName("*"),
                k = RegExp("(^|\\s)" + g + "(\\s|$)");
            m = 0;
            for (l = j.length; m < l; m++) {
                k.test(j[m].className) && n.push(j[m])
            }
        }
        return n.length > 1 ? n : n[0]
    }
})("audiojs", "audiojsInstance", this); (function (a) {
    a.jpopup = function (c, b) {
        var e;
        var d = this;
        d.$el = a(c);
        d.el = c;
        d.init = function () {
            d.options = a.extend({},
                a.jpopup.defaultOptions, b);
            if (!d.options.target) {
                var f = document.createElement("div");
                f.id = "tip";
                f.innerHTML = "<h1><a href='javascript:void(0)' onclick='$jpopup.startOrHiden()'>×</a>温馨提示</h1>有票了！！</p>";
                f.style.height = "0px";
                f.style.width = d.options.width + "px";
                f.style.bottom = "0px";
                f.style.position = "fixed";
                document.body.appendChild(f)
            } else {
                d.options.target.attr("id", "tip");
                d.options.target.css("height", "0px");
                d.options.target.css("width", d.options.width + "px");
                d.options.target.css("position", "fixed");
                d.options.target.css("margin-bottom", "0px")
            }
        };
        d.startOrHiden = function () {
            var f = document.getElementById("tip");
            if (parseInt(f.style.height) == 0) {
                f.style.display = "block";
                e = setInterval("$jpopup.changeH('up')", d.options.speed)
            } else {
                jPlayer("stop");
                e = setInterval("$jpopup.changeH('down')", d.options.speed)
            }
        };
        d.quickHide = function () {
            var f = document.getElementById("tip");
            f.style.height = "0px";
            f.style.display = "none"
        };
        d.isShow = function () {
            var f = document.getElementById("tip");
            return f && f.style.display == "block"
        };
        d.changeH = function (g) {
            var f = document.all ? document.all.tip : document.getElementById("tip");
            if (g == "up") {
                if (parseInt(f.style.height) >= d.options.height) {
                    clearInterval(e)
                } else {
                    f.style.height = (parseInt(f.style.height) + 8).toString() + "px"
                }
            }
            if (g == "down") {
                if (parseInt(f.style.height) < 8) {
                    clearInterval(e);
                    f.style.display = "none"
                } else {
                    f.style.height = (parseInt(f.style.height) - 8).toString() + "px"
                }
            }
        };
        d.init();
        window.$jpopup = d;
        return d
    };
    a.jpopup.defaultOptions = {
        width: 180,
        height: 100,
        target: null,
        speed: 20
    };
    a.fn.jpopup = function () {
        var b = Array.prototype.slice.call(arguments);
        return (new a.jpopup(this, b[0]))
    }
})(jQuery); (function (a) {
    a.autoSubmit = function (c) {
        var d = this;
        var b = ["YZ", "ZE", "YW", "ZY", "RZ", "SRRB", "YYRW", "RW", "TZ", "GR", "SWZ", "WZ"];
        d.init = function () {
            d.options = a.extend({},
                a.autoSubmit.defaultOptions, c)
        };
        d.isTrainPrior = function () {
            return "2" == a("#_prior").val()
        };
        d.autoSubmit = function (K, m, g, N) {
            var o = new Date().getTime();
            var w = [];
            var B = K.length;
            w[0] = 3;
            if (B <= 0) {
                return w
            }
            var A = g;
            var q = N;
            var C = A.length;
            var l = q.length;
            var M = m.length;
            var s = false;
            if (C == 0) {
                A = b;
                s = true;
                C = A.length
            }
            var I = [];
            var L = d.isTrainPrior();
            K = d.sortTrainPrior(K, q);
            for (var D = 0; D < C; D++) {
                var O = [];
                O.push(A[D].toLowerCase());
                var r = new Object();
                r.cType = A[D];
                r.cTrain = [];
                for (var G = 0; G < B; G++) {
                    var y = K[G];
                    var h = d.getXBSize(y, O);
                    if (a("#partSubmit").is(":checked") && L && h >= 1) {
                        y.cNum = h;
                        r.cTrain.push(y)
                    } else {
                        if (h >= M) {
                            y.cNum = h;
                            r.cTrain.push(y)
                        }
                    }
                }
                if (r.cTrain.length > 0) {
                    I.push(r)
                }
            }
            var p = I.length;
            if (p > 0) {
                debug("可以直接提交 start");
                if (L) {
                    debug("可以直接提交  车次优先");
                    for (var G = 0; G < B; G++) {
                        var f = K[G]["queryLeftNewDTO"]["station_train_code"];
                        debug("   检测到车次:" + f);
                        for (var D = 0; D < p; D++) {
                            var F = I[D];
                            if (d.checkTrainByTrainNo(F.cTrain, f)) {
                                debug("检测到车次:" + f + "  \t席别：" + F.cType);
                                debug("自动提交检测  车次优先,耗时:" + (new Date().getTime() - o) + "毫秒");
                                w[0] = 1;
                                w[1] = K[G];
                                if (a("#partSubmit").is(":checked")) {
                                    w[2] = A
                                } else {
                                    w[2] = [F.cType]
                                }
                                return w
                            }
                        }
                    }
                    debug("可以直接提交  车次优先  失败了,耗时：" + (new Date().getTime() - o) + "毫秒")
                } else {
                    debug("可以直接提交  席别优先");
                    var F = I[0];
                    var H = F.cTrain;
                    d.sortTrainZWNum(H, F.cType.toLowerCase() + "_num");
                    debug("检测到车次  可以直接提交  席别优先:" + H[0]["queryLeftNewDTO"]["station_train_code"] + "  \t席别：" + F.cType);
                    w[0] = 1;
                    w[1] = H[0];
                    w[2] = [F.cType];
                    debug("自动提交检测  可以直接提交  席别优先耗时:" + (new Date().getTime() - o) + "毫秒");
                    return w
                }
                return w
            }
            if (a("#partSubmit").is(":checked")) {
                debug("允许部分提交  start");
                var O = [];
                var n = [];
                for (var D = 0; D < C; D++) {
                    O.push(A[D].toLowerCase());
                    n.push(A[D]);
                    var r = new Object();
                    r.cTypes = [];
                    for (var v = 0; v <= D; v++) {
                        r.cTypes.push(A[D])
                    }
                    r.cTrain = [];
                    r.cTypeNum = D + 1;
                    for (var E = 0; E < B; E++) {
                        var y = K[E];
                        var u = d.getXBSize(y, O);
                        if (u > 0) {
                            y.cNum = u;
                            r.cTrain.push(y)
                        }
                    }
                    if (r.cTrain.length > 0) {
                        I.push(r)
                    }
                }
                p = I.length;
                if (p > 0) {
                    if (L) {
                        debug("\t满足部分提交  车次优先");
                        for (var G = 0; G < B; G++) {
                            var f = K[G]["queryLeftNewDTO"]["station_train_code"];
                            for (var D = 0; D < p; D++) {
                                var F = I[D];
                                if (d.checkTrainByTrainNo(F.cTrain, f)) {
                                    debug("检测到车次:" + f);
                                    debug("部分提交  车次优先,耗时:" + (new Date().getTime() - o) + "毫秒");
                                    w[0] = 2;
                                    w[1] = K[G];
                                    w[2] = A;
                                    return w
                                }
                            }
                        }
                        debug("\t满足部分提交  车次优先 过滤错误")
                    } else {
                        debug("\t满足部分提交  席别优先");
                        var e = new Object();
                        var z = 10000;
                        e[A[0]] = z;
                        for (var D = 1; D < C; D++) {
                            z = z / 5;
                            e[A[D]] = z
                        }
                        d.createXBWeight(K, A, e);
                        K.sort(function (k, j) {
                            var i = k.trainWeight;
                            var t = j.trainWeight;
                            if (i > t) {
                                return - 1
                            } else {
                                return 1
                            }
                        });
                        var J = K[0];
                        debug("\t满足部分提交  席别优先 根据权重排序之后首选车次：" + J.queryLeftNewDTO["station_train_code"] + "\t权重值:" + J.trainWeight);
                        debug("部分提交  席别优先,耗时:" + (new Date().getTime() - o) + "毫秒");
                        w[0] = 2;
                        w[1] = J;
                        w[2] = A;
                        return w
                    }
                }
            }
            return w
        };
        d.createXBWeight = function (o, n, g) {
            var e = o.length;
            for (var j = 0; j < e; j++) {
                var h = o[j];
                h.trainWeight = 0;
                var m = n.length;
                for (var f = 0; f < m; f++) {
                    var l = h.queryLeftNewDTO[n[f].toLowerCase() + "_num"];
                    if (l != "--" && l != "无") {
                        if (l == "有") {
                            h.trainWeight = h.trainWeight + 20 * g[n[f]]
                        } else {
                            l = Number(l);
                            h.trainWeight = h.trainWeight + l * g[n[f]]
                        }
                    }
                }
                debug("\t车次" + h.queryLeftNewDTO["station_train_code"] + "席别优先权值：" + h.trainWeight)
            }
        };
        d.checkTrainByTrainNo = function (g, h) {
            var f = g.length;
            if (f > 0) {
                for (var e = 0; e < f; e++) {
                    if (h == g[e]["queryLeftNewDTO"]["station_train_code"]) {
                        return true
                    }
                }
            }
            return false
        };
        d.sortTrainZWNum = function (e, f) {
            debug("   排序了！！！！！" + f);
            e.sort(function (i, h) {
                var g = i.queryLeftNewDTO[f];
                var j = h.queryLeftNewDTO[f];
                if (g != "--" && g != "无") {
                    if (g == "有") {
                        g = 20
                    } else {
                        g = Number(g)
                    }
                } else {
                    g = 0
                }
                if (j != "--" && j != "无") {
                    if (j == "有") {
                        j = 20
                    } else {
                        j = Number(j)
                    }
                } else {
                    j = 0
                }
                if (g > j) {
                    return - 1
                } else {
                    return 1
                }
            })
        };
        d.sortTrainPrior = function (f, j) {
            if (j.length > 0) {
                var h = [];
                for (var e = 0; e < j.length; e++) {
                    if (h.length == f.length) {
                        break
                    }
                    for (var g = 0; g < f.length; g++) {
                        if (j[e] == f[g]["queryLeftNewDTO"]["station_train_code"]) {
                            h.push(f[g]);
                            break
                        }
                    }
                }
                return h
            }
            return f
        };
        d.getXBSize = function (i, h, m) {
            var l = 0;
            var j = h.length;
            for (var e = 0; e < j; e++) {
                if (h[e] == "yyrw") {
                    var g = i.queryLeftNewDTO.seat_types;
                    if (h[e] == "yyrw" && g.indexOf("A") > -1) {
                        var f = i.queryLeftNewDTO.gr_num;
                        if (f != "--" && f != "无") {
                            if (f == "有") {
                                if (m) {
                                    m.cTypes.push("gr")
                                }
                                l += 20
                            } else {
                                f = Number(f);
                                if (f > 0) {
                                    if (m) {
                                        m.cTypes.push("gr")
                                    }
                                }
                                l += f
                            }
                        }
                    }
                } else {
                    var f = i.queryLeftNewDTO[h[e] + "_num"];
                    if (f != "--" && f != "无") {
                        if (f == "有") {
                            if (m) {
                                m.cTypes.push(h[e])
                            }
                            l += 20
                        } else {
                            f = Number(f);
                            if (f > 0) {
                                if (m) {
                                    m.cTypes.push(h[e])
                                }
                            }
                            l += f
                        }
                    }
                }
            }
            return l
        };
        d.sortedPriorXB = function (g) {
            var j = [];
            var e = b.length;
            for (var f = 0; f < e; f++) {
                if (j.length == g.length) {
                    break
                }
                for (var h = 0; h < g.length; h++) {
                    if (b[f] == g[h]) {
                        j.push(g[h]);
                        break
                    }
                }
            }
            return j
        };
        d.removeSameElem = function () {
            for (var f = 0; f < d.options.current_datas.length; f++) {
                for (var e = f + 1; e < d.options.current_datas.length; e++) {
                    if (d.equals(d.options.current_datas[f], d.options.current_datas[e])) {
                        d.options.current_datas = removeElement(e, d.options.current_datas);
                        f = -1;
                        break
                    }
                }
            }
            return d.options.current_datas
        };
        d.init();
        return d
    };
    a.autoSubmit.defaultOptions = {
        partSubmit: "partSubmit",
        allSubmit: "autoSubmit",
        prior: "_prior"
    };
    a.fn.autoSubmit = function () {
        var b = Array.prototype.slice.call(arguments);
        return (new a.autoSubmit(b[0]))
    }
})(jQuery); (function () {
    var a = "YZ,ZE,YW,WZ";
    jQuery.extend({
        checkSeatTypes: function () {
            if (xbChecked && xbChecked.length > 0) {
                for (var b = 0; b < xbChecked.length; b++) {
                    if (a.indexOf(xbChecked[b]) == -1) {
                        return false
                    }
                }
            }
            return true
        },
        canSelectThisSeatType: function (e) {
            var b = false;
            if (passengerChecked && passengerChecked.length > 0) {
                var d = passengerChecked.length;
                for (var c = 0; c < d; c++) {
                    var f = passengerChecked[c];
                    if (f.passenger_type == ticket_submit_order.passenger_type.student) {
                        b = true;
                        break
                    }
                }
            }
            if (b) {
                if (a.indexOf(e) == -1) {
                    return false
                }
            }
            return true
        }
    })
})();