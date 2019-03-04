(function(C) {
    jQuery.extend({
        ht_getcookie: function(W) {
            var k = document.cookie.indexOf(W);
            var i = document.cookie.indexOf(";", k);
            return k == -1 ? "": unescape(document.cookie.substring(k + W.length + 1, (i > k ? i: document.cookie.length)))
        },
        ht_setcookie: function(aa, Z, Y, X, k, W) {
            var i = new Date();
            i.setTime(i.getTime() + Y * 1000);
            document.cookie = escape(aa) + "=" + escape(Z) + (i ? "; expires=" + i.toGMTString() : "") + (X ? "; path=" + X: "; path=/") + (k ? "; domain=" + k: "") + (W ? "; secure": "")
        },
        textFocus: function(W) {
            var k, i, W = W === undefined ? 0 : parseInt(W);
            this.each(function() {
                if (!this.setSelectionRange) {
                    k = this.createTextRange();
                    W === 0 ? k.collapse(false) : k.move("character", W);
                    k.select()
                } else {
                    i = this.value.length;
                    W === 0 ? this.setSelectionRange(i, i) : this.setSelectionRange(W, W)
                }
                this.focus()
            });
            return this
        }
    });
    var w = [];
    var D = [];
    var E = [];
    var G = [];
    var v = 0;
    var y = 0;
    var A = 0;
    var S = 0;
    var U = false;
    var g = false;
    var H = false;
    var z = 0;
    var I = null;
    var m = -1;
    var N = {};
    var f = [];
    var e = [];
    var d = [];
    var b = [];
    var V = [];
    var F = new Array("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z");
    var j = [];
    var x = false;
    var c = [];
    for (var R = 0; R < 26; R++) {
        c[R] = []
    }
    var P = [];
    for (var T = 0; T < 5; T++) {
        P[T] = []
    }
    var t = [];
    var s = [];
    var q = [];
    var p = [];
    var o = [];
    var K = [];
    var a = false;
    var L = true;
    var u = 12;
    var h = "简码/汉字";
    var n = "简码/汉字";
    var r = "inp-txt_select";
    var l = "inp-txt";
    var B = false;
    var J = null;
    var Q = null;
    var M = false;
    var O = C.ht_getcookie("hj_favcity");
    C.stationFor12306 = {
        bindInputs: [],
        get_initInputValue: function() {
            return h
        },
        get_initTopInputValue: function() {
            return n
        },
        city_Bind: function(k) {
            if (k.length == 0) {
                return
            }
            var i = "";
            C.each(k,
            function(W) {
                if (O == k[W][2]) {
                    i += "<div class='cityline' id='citem_" + W + "' cturn='" + k[W][6] + "'><span class='ralign'><b>" + k[W][1] + "</b></span></div>\n"
                } else {
                    i += "<div class='cityline' id='citem_" + W + "' cturn='" + k[W][6] + "'><span class='ralign'>" + k[W][1] + "</span><span style='float:right;' class='ralign'>" + k[W][3] + "</span></div>\n"
                }
            });
            C("#panel_cities").html(i);
            C(".cityline").mouseover(function() {
                C.stationFor12306.city_shiftSelect(this)
            }).click(function() {
                C.stationFor12306.city_confirmSelect();
                E = C.stationFor12306.filterCity("");
                C.stationFor12306.city_showlist(0)
            });
            C.stationFor12306.city_shiftSelect(C("#citem_0"))
        },
        city_changeSelectIndex: function(i) {
            var k = A + i;
            if (k == -1) {
                C.stationFor12306.city_showlist(z - 1);
                C.stationFor12306.city_shiftSelect(C("#citem_" + (G.length - 1)))
            } else {
                if (k == G.length) {
                    C.stationFor12306.city_showlist(z + 1);
                    C.stationFor12306.city_shiftSelect(C("#citem_0"))
                } else {
                    C.stationFor12306.city_shiftSelect(C("#citem_" + k))
                }
            }
        },
        city_confirmSelect: function() {
            I.val(S[1]);
            curObjCode.val(S[2]);
            if (B) {
                C.stationFor12306.setStationInCookies(S[1], S[2])
            }
            C("#form_cities").css("display", "none");
            C("#form_cities2").css("display", "none");
            C("#form_cities3").css("display", "none");
            m = -1;
            y = 0;
            C.stationFor12306.setStationStyle();
            if (L) {
                C.stationFor12306.LoadJS(S[2])
            }
            if (J) {
                J(I, curObjCode)
            }
        },
        city_shiftSelect: function(k) {
            if (v != k) {
                if (v != 0) {
                    C(v).removeClass("citylineover").addClass("cityline").css("backgroundColor", "white")
                }
                if (k != 0) {
                    try {
                        v = k;
                        var i = C(v).removeClass("cityline").addClass("citylineover").css("backgroundColor", "#c8e3fc");
                        A = Number(i.attr("id").split("_")[1]);
                        S = w[Number(i.attr("cturn"))];
                        C("#cityid").val(S[2])
                    } catch(W) {}
                }
            }
        },
        city_shiftSelectInLi: function(i) {
            if (y != i) {
                if (y != 0) {
                    C(y).removeClass("ac_over").addClass("ac_odd")
                }
                if (i != 0) {
                    try {
                        y = i;
                        C(y).removeClass("ac_odd").addClass("ac_over")
                    } catch(k) {}
                }
            }
        },
        js: function(W) {
            var k;
            for (k = 1; k <= 7; k++) {
                if (C("#nav_list" + k).attr("class")) {
                    C("#ul_list" + k).css("display", "none");
                    C("#nav_list" + k).removeClass("action")
                }
            }
            for (k = 1; k <= 7; k++) {
                if (k == W) {
                    C("#ul_list" + k).css("display", "block");
                    C("#nav_list" + k).addClass("action");
                    if (k == 1 || k == 7) {
                        C("#flip_cities2").css("display", "none")
                    }
                    if (k > 1 && k < 7) {
                        var Y = C.stationFor12306.tHtmlGetCityName(W - 1, -1, 0);
                        if (Y > u) {
                            var X = Math.ceil(Y / u);
                            if (X > 1) {
                                C.stationFor12306.pageDesigh(X, 0, k)
                            }
                            C("#flip_cities2").css("display", "block")
                        } else {
                            C("#flip_cities2").css("display", "none")
                        }
                    } else {
                        I.focus()
                    }
                } else {
                    C("#ul_list" + k).css("display", "none");
                    C("#nav_list" + k).removeClass("action")
                }
            }
            if (1 != W) {
                C(".ac_even").on("mouseover",
                function() {
                    C.stationFor12306.city_shiftSelectInLi(this)
                }).on("click",
                function() {
                    I.val(C(this).text());
                    curObjCode.val(C(this).attr("data"));
                    if (B) {
                        C.stationFor12306.setStationInCookies(C(this).text(), C(this).attr("data"))
                    }
                    C("#form_cities2").css("display", "none");
                    m = -1;
                    y = 0;
                    C.stationFor12306.setStationStyle();
                    if (L) {
                        C.stationFor12306.LoadJS(C(this).attr("data"))
                    }
                    if (J) {
                        J(I, curObjCode)
                    }
                })
            }
        },
        tHtmlGetCityName: function(k, i, X) {
            switch (k) {
            case 0:
                if (i == -1) {
                    return D.length
                }
                if (i == -2) {
                    return D
                }
                return D[i];
                break;
            case 1:
                if (i == -1) {
                    return c[3].length
                }
                if (i == -2) {
                    return f
                }
                if (f.length > u) {
                    var W = Math.ceil((f.length) / u);
                    if (W > 1) {
                        t = f.slice(u * (X), Math.min(u * (X + 1), f.length));
                        return t[i]
                    }
                }
                return f[i];
                break;
            case 2:
                if (i == -1) {
                    return c[7].length
                }
                if (i == -2) {
                    return e
                }
                if (e.length > u) {
                    var W = Math.ceil((e.length) / u);
                    if (W > 1) {
                        s = e.slice(u * (X), Math.min(u * (X + 1), e.length));
                        return s[i]
                    }
                }
                return e[i];
                break;
            case 3:
                if (i == -1) {
                    return c[11].length
                }
                if (i == -2) {
                    return d
                }
                if (d.length > u) {
                    var W = Math.ceil((d.length) / u);
                    if (W > 1) {
                        q = d.slice(u * (X), Math.min(u * (X + 1), d.length));
                        return q[i]
                    }
                }
                return d[i];
                break;
            case 4:
                if (i == -1) {
                    return c[18].length
                }
                if (i == -2) {
                    return b
                }
                if (b.length > u) {
                    var W = Math.ceil((b.length) / u);
                    if (W > 1) {
                        p = b.slice(u * (X), Math.min(u * (X + 1), b.length));
                        return p[i]
                    }
                }
                return b[i];
                break;
            case 5:
                if (i == -1) {
                    return c[24].length
                }
                if (i == -2) {
                    return V
                }
                if (V.length > u) {
                    var W = Math.ceil((V.length) / u);
                    if (W > 1) {
                        o = V.slice(u * (X), Math.min(u * (X + 1), V.length));
                        return o[i]
                    }
                }
                return V[i];
                break;
            default:
                return "error";
                break
            }
        },
        closeShowCity: function() {
            C("#form_cities2").css("display", "none");
            m = -1;
            y = 0;
            C.each(C.stationFor12306.bindInputs,
            function(Y, X) {
                var W = "#" + X;
                var k = "#" + X + "Text";
                var i = C(k).val();
                if ("" == i) {
                    C(k).val(h);
                    C.stationFor12306.from_to_station_class_gray(C(k));
                    C(W).val("")
                }
            })
        },
        showAllCity: function() {
            var ab = "";
            var k = "440px";
            if (B) {
                k = "400px"
            }
            ab = '<div class="com_hotresults" id="thetable" style="width:' + k + '"><div style="width:100%;"><div class="ac_title"><span>拼音支持首字母输入</span><a class="ac_close" style="cursor:pointer" title="关闭" onclick="$.stationFor12306.closeShowCity()"></a></div><ul class="AbcSearch clx" id="abc">';
            if (B) {
                ab = ab + '<li class="action" index="7" method="liHotTab"  onclick="$.stationFor12306.js(7)" id="nav_list7">常用</li>'
            }
            ab = ab + '<li index="1" method="liHotTab"  onclick="$.stationFor12306.js(1)" id="nav_list1">热门</li><li index="2" method="liHotTab"  onclick="$.stationFor12306.js(2)" id="nav_list2">ABCDE</li><li index="3" method="liHotTab"  onclick="$.stationFor12306.js(3)" id="nav_list3">FGHIJ</li><li index="4" method="liHotTab"  onclick="$.stationFor12306.js(4)" id="nav_list4">KLMNO</li><li index="5" method="liHotTab"  onclick="$.stationFor12306.js(5)" id="nav_list5">PQRST</li><li index="6" method="liHotTab"  onclick="$.stationFor12306.js(6)" id="nav_list6">UVWXYZ</li></ul>';
            if (B) {
                ab += '<ul class="popcitylist" style="overflow: auto;max-height: 280px;height: 191px;" method="hotData" id="ul_list7">';
                var ac = C.stationFor12306.getStationInCookies();
                var Y = ac.length;
                if (Y > 2) {
                    M = true;
                    for (var ad = 0; ad < Y; ad++) {
                        ab += '<li class="ac_even"   title="' + ac[ad][0] + '" data="' + ac[ad][1] + '">' + ac[ad][0] + "</li>"
                    }
                }
                ab += "</ul>"
            }
            ab += '<ul class="popcitylist" style="overflow: auto;max-height: 280px;height: 191px;display:none;" method="hotData" id="ul_list1">';
            var X = C.stationFor12306.tHtmlGetCityName(0, -1, 0);
            var aa = "";
            if (!B) {
                aa = " openLi"
            }
            for (var ad = 0; ad < X; ad++) {
                ab += '<li class="ac_even' + aa + '"   title="' + C.stationFor12306.tHtmlGetCityName(0, ad, 0)[1] + '" data="' + C.stationFor12306.tHtmlGetCityName(0, ad, 0)[2] + '">' + C.stationFor12306.tHtmlGetCityName(0, ad, 0)[1] + "</li>"
            }
            ab += "</ul>";
            for (var ae = 2; ae <= 6; ae++) {
                var Z = ae - 1;
                var i = C.stationFor12306.tHtmlGetCityName(Z, -1, 0);
                if (i > u) {
                    var W = Math.ceil((i) / u);
                    if (W > 1) {
                        ab += '<div id="ul_list' + ae + '">';
                        C.stationFor12306.pageDesigh(W, 0, ae)
                    }
                    C("#flip_cities2").css("display", "block")
                } else {
                    ab += '<ul  class="popcitylist" style="overflow: auto; max-height: 260px; height: 191px;display:none;" id="ul_list' + ae + '">';
                    C("#flip_cities2").css("display", "none");
                    var aa = "";
                    if (!B) {
                        aa = " openLi"
                    }
                    for (var ad = 0; ad < C.stationFor12306.tHtmlGetCityName(Z, -1, 0); ad++) {
                        ab += '<li class="ac_even' + aa + '"   title="' + C.stationFor12306.tHtmlGetCityName(Z, ad, 0)[1] + '" data="' + C.stationFor12306.tHtmlGetCityName(Z, ad, 0)[2] + '">' + C.stationFor12306.tHtmlGetCityName(Z, ad, 0)[1] + "</li>"
                    }
                }
                ab += "</div>"
            }
            ab += '<div id="flip_cities2"> 翻页控制区</div>';
            ab += "</div>";
            C("#panel_cities2").html(ab);
            C("#thetable").on("click",
            function() {
                if (C("#form_cities2").css("display") == "block") {
                    if (m == 1 | m == 0) {
                        m == -1
                    }
                    I.select()
                }
            });
            C("#form_cities").on("click",
            function() {
                if (C("#form_cities").css("display") == "block") {
                    if (m == 1 | m == 0) {
                        m == -1
                    }
                    I.select()
                }
            });
            C(".ac_even").on("mouseover",
            function() {
                C.stationFor12306.city_shiftSelectInLi(this)
            }).on("click",
            function() {
                I.val(C(this).text());
                curObjCode.val(C(this).attr("data"));
                if (B) {
                    C.stationFor12306.setStationInCookies(C(this).text(), C(this).attr("data"))
                }
                C("#form_cities2").css("display", "none");
                m = -1;
                y = 0;
                C.stationFor12306.setStationStyle();
                if (L) {
                    C.stationFor12306.LoadJS(C(this).attr("data"))
                }
                if (J) {
                    J(I, curObjCode)
                }
            });
            C("#flip_cities2").css("display", "none");
            return w
        },
        LoadJS: function(W) {
            if (((typeof(mm_addjs) != "undefined")) && ("" != mm_addjs) && (mm_addjs == 1)) {
                var k = document.getElementsByTagName("HEAD").item(0);
                var i = document.createElement("SCRIPT");
                i.src = mm_srcjs + W + ".js";
                i.type = "text/javascript";
                k.appendChild(i)
            }
        },
        addZMHtml: function(X, Y) {
            var W = "";
            if (X && X.length > 0) {
                var Z = X[0][0].charAt(0);
                W += '<ul  class="popcitylist" style="overflow: auto; max-height: 260px; " >';
                W += '<li class="ac_letter">' + Z.toUpperCase() + "</li>";
                for (var i = 0; i < 12; i++) {
                    var k = X[i];
                    if (k) {
                        W += '<li class="ac_even' + Y + '"   title="' + k[1] + '" data="' + k[2] + '">' + k[1] + "</li>"
                    } else {
                        W += '<li class="ac_even' + Y + '" </li>'
                    }
                }
                W += "</ul>"
            }
            return W
        },
        pageDesigh: function(Z, ac, ad) {
            var W = "";
            if (Z > 1) {
                if (ac == -1) {
                    ac = (Z - 1)
                } else {
                    if (ac == Z) {
                        ac = 0
                    }
                }
                var ab = "";
                if (!B) {
                    ab = " openLi"
                }
                for (var X = 2; X <= 6; X++) {
                    if (X == ad) {
                        var aa = P[X - 2];
                        for (var i = 0; i < aa.length; i++) {
                            K = aa[i].slice(ac * u, (ac + 1) * u);
                            W += C.stationFor12306.addZMHtml(K, ab)
                        }
                    }
                }
                C("#ul_list" + ad).html(W);
                C("#ul_list" + ad).css("height", 270);
                if (W) {
                    var Y = (ac == 0) ? "&laquo;&nbsp;上一页": "<a style='cursor:pointer'    class='cityflip' onclick='$.stationFor12306.pageDesigh(" + Z + "," + (ac - 1) + "," + ad + ");return false;'>&laquo;&nbsp;上一页</a>";
                    Y += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;";
                    Y += (ac == Z - 1) ? "下一页&nbsp;&raquo;": "<a style='cursor:pointer' class='cityflip'  onclick='$.stationFor12306.pageDesigh(" + Z + "," + (ac + 1) + "," + ad + ")'>下一页&nbsp;&raquo;</a>";
                    C("#flip_cities2").html(Y)
                } else {
                    C("#flip_cities2").html("")
                }
                if (m == 1 | m == 0 | m == 2) {
                    m == -1
                }
                if (I) {
                    I.select()
                }
            } else {}
            C(".ac_even").on("mouseover",
            function() {
                C.stationFor12306.city_shiftSelectInLi(this)
            }).on("click",
            function() {
                I.val(C(this).text());
                curObjCode.val(C(this).attr("data"));
                if (B) {
                    C.stationFor12306.setStationInCookies(C(this).text(), C(this).attr("data"))
                }
                C("#form_cities2").css("display", "none");
                m = -1;
                y = 0;
                C.stationFor12306.setStationStyle();
                if (L) {
                    C.stationFor12306.LoadJS(C(this).attr("data"))
                }
                if (J) {
                    J(I, curObjCode)
                }
            })
        },
        filterCity: function(Z) {
            if (Z.length == 0) {
                C("#top_cities").html(n);
                return w
            }
            var Y = /<\/?[^>]*>/g;
            Z = Z.replace(Y, "");
            var W = [];
            var k = /[^A-z]/.test(Z);
            for (var X = 0; X < w.length; X++) {
                if (C.stationFor12306.isMatchCity(w[X], Z, k)) {
                    W.push(w[X])
                }
            }
            if (W.length > 0) {
                C("#top_cities").html('按"<font color=red>' + Z + '</font>"检索：');
                return W
            } else {
                C("#top_cities").html("无法匹配:<font color=red>" + Z + "</font>");
                return []
            }
        },
        replaceChar: function(i, W, k) {
            return i.substr(0, W) + k + i.substr(W + 1, i.length - 1)
        },
        isMatchCity: function(Z, ac, W) {
            var ac = ac.toLowerCase();
            var k = [Z[4].toLowerCase(), Z[1], Z[3].toLowerCase()];
            var ab = -1;
            var Y = -1;
            if (W) {
                ac = ac.split("");
                for (var X = 0; X < ac.length; X++) {
                    var ae = k[1].indexOf(ac[X]);
                    if (ae > ab && ae <= X) {
                        k[1] = C.stationFor12306.replaceChar(k[1], ae, "-");
                        ab = ae
                    } else {
                        return false
                    }
                }
            } else {
                ac = ac.split("");
                var i = true;
                var aa = true;
                for (var X = 0; X < ac.length; X++) {
                    var ae = k[0].indexOf(ac[X]);
                    if (ae > ab && ae <= X) {
                        k[0] = C.stationFor12306.replaceChar(k[0], ae, "-");
                        ab = ae
                    } else {
                        i = false;
                        break
                    }
                }
                for (var X = 0; X < ac.length; X++) {
                    var ad = k[2].indexOf(ac[X]);
                    if (ad > Y && ad <= X) {
                        k[2] = C.stationFor12306.replaceChar(k[2], ad, "-");
                        Y = ad
                    } else {
                        aa = false;
                        break
                    }
                }
                if ((i == false) && (aa == false)) {
                    return false
                }
            }
            return true
        },
        city_showlist_page: function(ad, Y) {
            var Z = "";
            Z += '<div class="citypage">';
            Z += (ad == 0) ? "": '<a href="#" class="pagetxt" onclick="$.stationFor12306.city_showlist(' + (ad - 1) + ');return false;"><<</a>';
            var ae = ad + 1;
            var aa = Y;
            var ab = 2;
            var ac = 5;
            var k = (ae - ab) > 0 ? (ae + ab > aa ? aa - ac + 1 : ae - ab) : 1;
            var W = k + ac > aa ? aa + 1 : k + ac;
            if (aa < ac) {
                for (var X = 1; X < aa + 1; X++) {
                    if (ae == X) {
                        Z += "<a href='' class='cur' onclick='$.stationFor12306.city_showlist(" + (X - 1) + ");return false;'>" + (X) + "</a>"
                    } else {
                        Z += "<a href='' onclick='$.stationFor12306.city_showlist(" + (X - 1) + ");return false;'>" + (X) + "</a>"
                    }
                }
            } else {
                for (var X = k; X < W; X++) {
                    if (ae == X) {
                        Z += "<a href='' class='cur' onclick='$.stationFor12306.city_showlist(" + (X - 1) + ");return false;'>" + (X) + "</a>"
                    } else {
                        Z += "<a href='' onclick='$.stationFor12306.city_showlist(" + (X - 1) + ");return false;'>" + (X) + "</a>"
                    }
                }
            }
            Z += (ad == Y - 1) ? "": '<a href="" class="pagetxt" onclick="$.stationFor12306.city_showlist(' + (ad + 1) + ');return false;">>></a>';
            Z += "</div>";
            return Z
        },
        city_showlist: function(W) {
            if (E.length > 6) {
                var k = Math.ceil((E.length) / 6);
                if (W == -1) {
                    W = (k - 1)
                } else {
                    if (W == k) {
                        W = 0
                    }
                }
                G = E.slice(6 * (W), Math.min(6 * (W + 1), E.length));
                C.stationFor12306.city_Bind(G);
                var i = "";
                i += C.stationFor12306.city_showlist_page(W, k);
                C("#flip_cities").html(i);
                C("#flip_cities").css("display", "block")
            } else {
                W = 0;
                G = E;
                C.stationFor12306.city_Bind(G);
                C("#flip_cities").css("display", "none")
            }
            z = W;
            if (C("#form_cities").css("display") == "block") {
                a = true;
                I.focus()
            }
        },
        fixDivBugInIE6: function(i) {
            try {
                i.bgiframe();
                if (i.width() > C("> ul", i).width()) {
                    i.css("overflow", "hidden")
                } else {
                    C("> iframe.bgiframe", i).width(C("> ul", i).width());
                    i.css("overflow", "scroll")
                }
                if (i.height() > C("> ul", i).height()) {
                    i.css("overflow", "hidden")
                } else {
                    C("> iframe.bgiframe", i).height(C("> ul", i).height());
                    i.css("overflow", "scroll")
                }
            } catch(k) {}
        },
        clearStation: function(i) {
            m = -1;
            var W = I.val();
            var X = curObjCode.val();
            if (W == "" || X == "") {
                I.val("");
                curObjCode.val("")
            } else {
                var k = W + "|" + X;
                if (typeof(station_names) != "undefined") {
                    if (station_names.indexOf(k) == -1) {
                        I.val("");
                        curObjCode.val("")
                    } else {
                        if ("click" == i) {
                            I.select();
                            if (C("#form_cities").is(":hidden")) {
                                C("#form_cities2").css("display", "block")
                            }
                        }
                    }
                } else {
                    I.val("");
                    curObjCode.val("")
                }
            }
        },
        MapCityID: function(W) {
            for (var k = 0; k < w.length; k++) {
                if (w[k][1] == W) {
                    return w[k][2]
                }
            }
            return 0
        },
        MapCityName: function(k) {
            for (var W = 0; W < w.length; W++) {
                if (w[W][2] == k) {
                    return w[W][1]
                }
            }
            return ""
        },
        SetISPos: function(Y) {
            if (Q) {
                Q(C("#form_cities"), C("#form_cities2"))
            } else {
                C("#form_cities").css("left", Y.position().left);
                C("#form_cities").css("top", Y.position().top + Y.height() + 12);
                C("#form_cities2").css("left", Y.position().left);
                C("#form_cities2").css("top", Y.position().top + Y.height() + 12)
            }
            var X = Y.offset().top;
            var i = C("#search_div");
            var k = C("#choice_div");
            i.css("top", X);
            k.css("top", X);
            var W = Y.offset().left;
            i.css("left", W);
            k.css("left", W)
        },
        myHandlerFg: function(i) {
            if (i == null) {
                i.keyCode = 9
            } else {
                if (!i.which && i.which == 13) {
                    i.preventDefault()
                } else {
                    if (i.which && i.keyCode == 13) {
                        i.which = 9
                    }
                }
            }
        },
        myHandler2: function(i) {
            if (i == null) {
                i = window.event;
                i.returnValue = false
            } else {
                if (i.which && i.which == 13) {
                    var W = document.getElementById("Upload_Data3");
                    if (document.createEvent) {
                        var k = document.createEvent("MouseEvents");
                        k.initEvent("click", true, false);
                        W.dispatchEvent(k)
                    } else {
                        if (document.createEventObject) {
                            W.fireEvent("onclick")
                        }
                    }
                } else {
                    if (!i.which && i.which == 13) {
                        i.preventDefault()
                    }
                }
            }
        },
        from_to_station_class_plain: function(i) {
            if (l && l != "") {
                i.removeClass(l)
            }
            if (r && r != "") {
                i.addClass(r)
            }
        },
        from_to_station_class_gray: function(i) {
            if (r && r != "") {
                i.removeClass(r)
            }
            if (l && l != "") {
                i.addClass(l)
            }
        },
        setStationStyle: function() {
            var i = I.val();
            if (i == "") {
                I.val(h);
                C.stationFor12306.from_to_station_class_gray(I);
                curObjCode.val("")
            } else {
                C.stationFor12306.from_to_station_class_plain(I)
            }
        },
        setCurValue: function() {
            I.val(S[1]);
            curObjCode.val(S[2])
        },
        bindEvent: function(i) {
            var W = "#" + i;
            var k = "#" + i + "Text";
            C(k).keydown(function(Y) {
                I = C(k);
                curObjCode = C(W);
                m = 0;
                a = true;
                L = true;
                C("#form_cities2").css("display", "none");
                y = 0;
                var X = C(k).width();
                if ( - [1, ]) {
                    X = X - 4
                }
                X = X < 220 ? 220 : X;
                C("#form_cities").css("width", X);
                C("#form_cities").css("display", "block");
                C(".AbcSearch li").removeClass("action");
                C(".popcitylist").css("display", "none");
                if (M && B) {
                    C("#ul_list7").css("display", "block");
                    C("#nav_list7").addClass("action")
                } else {
                    C("#nav_list1").addClass("action");
                    C("#ul_list1").css("display", "block")
                }
                C("#flip_cities2").css("display", "none");
                C(".ac_even").removeClass("ac_over").addClass("ac_odd");
                Y = Y || window.event;
                if (Y.keyCode == 40) {
                    C.stationFor12306.city_changeSelectIndex(1);
                    C("#form_cities").css("display", "block");
                    C.stationFor12306.SetISPos(I);
                    C.stationFor12306.setCurValue()
                } else {
                    if (Y.keyCode == 38) {
                        C.stationFor12306.city_changeSelectIndex( - 1);
                        C.stationFor12306.setCurValue();
                        C("#form_cities").css("display", "block");
                        C.stationFor12306.SetISPos(I)
                    } else {
                        if (Y.keyCode == 13) {
                            C.stationFor12306.city_confirmSelect();
                            if (document.addEventListener) {
                                document.addEventListener("keypress", C.stationFor12306.myHandlerFg, true)
                            } else {
                                evt = window.event;
                                evt.keyCode = 9
                            }
                        }
                    }
                }
            }).focus(function() {
                L = true;
                if (a) {
                    C("#form_cities2").css("display", "none");
                    y = 0;
                    a = false;
                    m = -1
                } else {
                    if (m == -1) {
                        C(".AbcSearch li").removeClass("action");
                        C(".popcitylist").css("display", "none");
                        C("#flip_cities2").css("display", "none");
                        if (M && B) {
                            C("#ul_list7").css("display", "block");
                            C("#nav_list7").addClass("action")
                        } else {
                            C("#nav_list1").addClass("action");
                            C("#ul_list1").css("display", "block")
                        }
                        C(".ac_even").removeClass("ac_over").addClass("ac_odd");
                        C("#form_cities2").css("display", "block");
                        for (var X = 2; X <= 6; X++) {
                            C("#ul_list" + X).css("height", 0)
                        }
                    }
                }
                I = C(k);
                curObjCode = C(W);
                m = 0;
                U = true;
                C.stationFor12306.SetISPos(I)
            }).blur(function() {
                I = C(k);
                curObjCode = C(W);
                m = 0;
                a = false;
                L = true;
                if (!g && !H) {
                    C.stationFor12306.clearStation("blur");
                    U = false;
                    C("#form_cities").css("display", "none");
                    C("#form_cities2").css("display", "none");
                    m = -1;
                    y = 0;
                    E = C.stationFor12306.filterCity("");
                    C.stationFor12306.city_showlist(0);
                    C.stationFor12306.setStationStyle()
                }
            }).keyup(function(X) {
                I = C(k);
                curObjCode = C(W);
                m = 0;
                a = true;
                X = X || window.event;
                if (X.keyCode != 40 && X.keyCode != 38 && X.keyCode != 37 && X.keyCode != 39 && X.keyCode != 13 && X.keyCode != 9) {
                    E = C.stationFor12306.filterCity(I.val());
                    C.stationFor12306.city_showlist(0)
                }
            }).click(function() {
                C.stationFor12306.clearStation("click")
            });
            C.stationFor12306.bindInputs.push(i)
        },
        getStationInCookies: function() {
            var W = [];
            var k = C.ht_getcookie("_city_name_save_station");
            if (k) {
                var i = k.split(",");
                if (i && i.length > 0) {
                    C.each(i,
                    function(aa, Z) {
                        var X = Z.split("#");
                        var Y = [];
                        Y[0] = X[0];
                        Y[1] = X[1];
                        W[aa] = Y
                    })
                }
            }
            return W
        },
        setStationInCookies: function(af, W) {
            var ac = C.stationFor12306.getStationInCookies();
            var Z = [];
            var ag = ac.length;
            var Y = true;
            var ah = 10;
            for (var aa = 0; aa < ag; aa++) {
                if (ac[aa][0] == af && ac[aa][1] == W) {
                    Y = false
                }
                Z.push(ac[aa])
            }
            if (Y) {
                Z.push([af, W])
            }
            var ab = Z;
            var X = "";
            var ad = ab.length;
            var aa = 0;
            if (ad > ah) {
                aa = 1
            }
            var i = aa;
            if (ad > 1) {
                C("#ul_list7").html("");
                M = true
            }
            var ae = "";
            for (; aa < ad; aa++) {
                if (aa > i) {
                    X += ","
                }
                X += ab[aa][0] + "#" + ab[aa][1];
                if (M && B) {
                    ae += '<li class="ac_even" onmouseover="$.stationFor12306.city_shiftSelectInLi(this);" onclick="$.stationFor12306.li_click(this);"   title="' + ab[aa][0] + '" data="' + ab[aa][1] + '">' + ab[aa][0] + "</li>"
                }
            }
            if (M && B) {
                C("#ul_list7").html(ae)
            }
            C.ht_setcookie("_city_name_save_station", X, 365 * 24 * 60 * 60)
        },
        li_click: function(i) {
            I.val(C(i).text());
            curObjCode.val(C(i).attr("data"));
            if (B) {
                C.stationFor12306.setStationInCookies(C(i).text(), C(i).attr("data"))
            }
            C("#form_cities2").css("display", "none");
            m = -1;
            y = 0;
            C.stationFor12306.setStationStyle();
            if (L) {
                C.stationFor12306.LoadJS(C(i).attr("data"))
            }
            if (J) {
                J(I, curObjCode)
            }
        },
        init: function(ac, ad) {
            if (typeof(ad) != "undefined") {
                if (typeof(ad._init_input) != "undefined") {
                    h = ad._init_input
                }
                if (typeof(ad._top_4_initInput) != "undefined") {
                    n = ad._top_4_initInput
                }
                if (typeof(ad.confirmCallBack) != "undefined") {
                    J = ad.confirmCallBack
                }
                if (typeof(ad._selected_class) != "undefined") {
                    r = ad._selected_class
                }
                if (typeof(ad._unselected_class) != "undefined") {
                    l = ad._unselected_class
                }
                if (typeof(ad._12306_openFavorite) != "undefined") {
                    B = ad._12306_openFavorite
                }
                if (typeof(ad.position) != "undefined") {
                    Q = ad.position
                }
            }
            if (typeof(station_names) != "undefined") {
                var Z = station_names.split("@");
                for (var Y = 0; Y < Z.length; Y++) {
                    var ab = Z[Y];
                    var aa = ab.toString().charAt(0);
                    for (var X in F) {
                        if (aa == F[X]) {
                            c[X].push(ab.split("|"))
                        }
                    }
                    if (ab.length > 0) {
                        ab = ab.split("|");
                        if (O != "" && ab[2] == O) {
                            favcity = ab;
                            w.unshift(ab);
                            if (Y > 6) {
                                w.push(ab)
                            }
                        } else {
                            w.push(ab)
                        }
                    }
                }
                f = c[0].concat(c[1]).concat(c[2]).concat(c[3]).concat(c[4]);
                e = c[5].concat(c[6]).concat(c[7]).concat(c[8]).concat(c[9]);
                d = c[10].concat(c[11]).concat(c[12]).concat(c[13]).concat(c[14]);
                b = c[15].concat(c[16]).concat(c[17]).concat(c[18]).concat(c[19]);
                V = c[20].concat(c[21]).concat(c[22]).concat(c[23]).concat(c[24]).concat(c[25]);
                P[0] = [c[0], c[1], c[2], c[3], c[4]];
                P[1] = [c[5], c[6], c[7], c[8], c[9]];
                P[2] = [c[10], c[11], c[12], c[13], c[14]];
                P[3] = [c[15], c[16], c[17], c[18], c[19]];
                P[4] = [c[20], c[22], c[23], c[24], c[25]];
                for (var Y = 0; Y < w.length; Y++) {
                    w[Y].push(Y)
                }
            }
            if (typeof(favorite_names) != "undefined") {
                var W = favorite_names.split("@");
                for (var Y = 0; Y < W.length; Y++) {
                    var ab = W[Y];
                    if (ab.length > 0) {
                        ab = ab.split("|");
                        D.push(ab)
                    }
                }
                for (var Y = 0; Y < D.length; Y++) {
                    D[Y].push(Y)
                }
            }
            E = C.stationFor12306.filterCity("");
            C.stationFor12306.city_showlist(0);
            C.stationFor12306.showAllCity();
            a = false;
            C.stationFor12306.fixDivBugInIE6(C("#form_cities"));
            C.stationFor12306.fixDivBugInIE6(C("#form_cities2"));
            if (ac && ac.length > 0) {
                C.each(ac,
                function(k, i) {
                    C.stationFor12306.bindEvent(i)
                })
            }
            C("#form_cities").mousedown(function() {
                g = true
            }).mouseup(function() {
                g = false
            });
            C("#form_cities2").mousedown(function() {
                H = true
            }).mouseup(function() {
                H = false
            })
        }
    }
})(jQuery); (function() {
    $.stopStation = function(a) {
        var b = this;
        b.init = function() {
            b.options = $.extend({},
            $.stopStation.defaultOptions, a);
            if (null == b.options.url || null == b.options.getSearchDate) {
                throw "error options,url can not be null"
            }
            b.options.mouseOnPanel = 0;
            if (!$("#" + b.options.showDivId)[0]) {
                var d = [];
                var c = -1;
                d[++c] = '<div class="station" style="display:none;" id="' + b.options.showDivId + '"><b></b>';
                d[++c] = '<div class="station-info" id="' + b.options.showTitleId + '"></div>';
                d[++c] = '<div class="station-hd"><span class="zx">站序</span><span class="zm">站名</span><span class="dzsj">到站时间</span>';
                d[++c] = '<span class="cfsj">出发时间</span><span class="tlsj">停留时间</span>';
                d[++c] = '<a id="_stopStation_close_id" class="close" title="关闭" href="javascript:" </a></div>';
                d[++c] = '<div class="station-bd"><table><tbody id="' + b.options.showTableId + '"></tbody></table></div></div>';
                $(d.join("")).appendTo($("body:eq(0)"));
                $("#_stopStation_close_id").on("click", b.close)
            }
            $("#" + b.options.showDivId).css("z-index", "20001");
            if (b.options.mouseOutClose) {
                $("#" + b.options.showDivId).on("mouseenter",
                function(e) {
                    b.options.mouseOnPanel = 1
                }).on("mouseleave",
                function() {
                    b.options.mouseOnPanel = 0;
                    $("#" + b.options.showDivId).hide().appendTo($("body:eq(0)"));
                    $("#" + b.options.showTableId).html("")
                })
            }
        };
        b.close = function() {
            $("#" + $.stopStation.defaultOptions.showDivId).closest("tr").removeAttr("style");
            $("#" + $.stopStation.defaultOptions.showDivId).removeAttr("style");
            b.options.mouseOnPanel = 0;
            $("#" + $.stopStation.defaultOptions.showDivId).hide().appendTo($("body:eq(0)"));
            $("#" + $.stopStation.defaultOptions.showTableId).html("")
        };
        b.open = function(f, j, h, e, i, c) {
            $("#" + $.stopStation.defaultOptions.showDivId).attr("style", "z-index:20001");
            if (a.timer) {
                clearTimeout(a.timer)
            }
            var g = a.getSearchDate();
            if (i && "" != i && null != i) {
                var d = formatDate(i);
                if ("-" != d) {
                    g = formatDate(i)
                } else {
                    g = a.getSearchDate()
                }
            } else {
                g = a.getSearchDate()
            }
            $.ajax({
                url: a.url,
                type: "get",
                isTakeParam: false,
                beforeSend: function(k) {
                    k.setRequestHeader("If-Modified-Since", "0");
                    k.setRequestHeader("Cache-Control", "no-cache")
                },
                data: {
                    train_no: j,
                    from_station_telecode: h,
                    to_station_telecode: e,
                    depart_date: g
                },
                success: function(p) {
                    var t = p.data.data;
                    if (t && t.length > 0) {
                        var r = [];
                        var u = -1;
                        for (var q = 0; q < t.length; q++) {
                            var l = t[q];
                            if (q == 0) {
                                var n = null;
                                n = l.train_class_name;
                                var s = l.service_type;
                                if ("0" == s) {
                                    c = "无空调"
                                } else {
                                    c = "有空调"
                                }
                                if (!n) {
                                    n = "&nbsp;&nbsp;"
                                }
                                $("#" + $.stopStation.defaultOptions.showTitleId).html('<span class="item1">' + l.station_train_code + '次      </span><span class="item2">' + l.start_station_name + "<em>--></em>" + l.end_station_name + '</span><span class="item3">' + n + '</span><span class="item4">' + c + "</span>").find("span").css("color", "#333")
                            }
                            var m = "";
                            if (!l.isEnabled) {
                                m = " style='color: #999;' "
                            }
                            r[++u] = '<tr><td width="50" class="tc" ' + m + ">" + l.station_no + "</td>";
                            r[++u] = '<td width="75" ' + m + ">" + l.station_name + "</td>";
                            r[++u] = '<td width="75" ' + m + ">" + l.arrive_time + "</td>";
                            r[++u] = '<td width="75" ' + m + ">" + l.start_time + "</td>";
                            r[++u] = "<td " + m + ">" + l.stopover_time + "</td></tr>"
                        }
                        $("#" + $.stopStation.defaultOptions.showTableId).html(r.join(""));
                        var o = $("#" + $.stopStation.defaultOptions.appendTo + f);
                        $("#" + $.stopStation.defaultOptions.showDivId).appendTo(o).show();
                        $(".ticket-info").filter("div").attr("style", "");
                        o[0].style["z-index"] = 19999;
                        if (! (navigator.appVersion.indexOf("MSIE 6") > -1)) {} else {}
                    }
                }
            })
        };
        b.init();
        myStopStation = b;
        return b
    };
    $.fn.stopStation = function() {
        return (new $.stopStation(Array.prototype.slice.call(arguments)[0]))
    };
    $.stopStation.defaultOptions = {
        url: null,
        mouseOutClose: false,
        showDivId: "train_div_",
        showTableId: "train_table_",
        showTitleId: "train_span_",
        appendTo: "train_num_",
        getSearchDate: null
    }
})();
var myStopStation = function() {};
var formatDate = function(b) {
    if (b && (b.length == 8)) {
        var c = b.substring(0, 4);
        var d = b.substring(4, 6);
        var a = b.substring(6, 8);
        return c + "-" + d + "-" + a
    } else {
        return "-"
    }
};
var checkusermdId;
var showTrainStop;
var hideTrainStop;
var showTicketPrice;
var isInitQueryInput = false;
var isInitStationDiv = false;
var isInitJsrenderTemplate = false;
var isInitDateRange = false;
var tickets_info;
var location_code;
var md5Str;
var leftTicketStr;
var isAsync;
var box;
var countDown = null;
var ischeckAutoSubmitCode = true;
var hainan_tip;
var firstShow = 1;
var endShow = 20;
var dataNumber = 0;
var change_dates_arr = [];
var isOther = true;
var dwTranTimeStr;
var ydTranTimeStr;
var uninputmsg = "用户名／邮箱／手机号码";
var adtimeout = 5000;
var iframeUrl = "https://ad.12306.cn/res/0004.html";
var frameComplete = false;
var iframeOnload = function() {
    frameComplete = true
};
var yxTrainPageSize = 15;
var passengerPageSize = 20;
var timer_time = 3;
var yxTrainChange = "";
var trainListForIE = [];
var queryLeftTicket_times = 0;
var queryLeftTicket_count = 10;
var ifAlertCode = false;
var intervalTime;
var seatTypeForHB = {
    SWZ: "9_商务座",
    TZ: "P_特等座",
    ZY: "M_一等座",
    ZE: "O_二等座",
    GR: "6_高级软卧",
    RW: "4_软卧",
    SRRB: "F_动卧",
    YW: "3_硬卧",
    RZ: "2_软座",
    YZ: "1_硬座",
    WZ: "1_无座",
    QT: "H_其他"
};
var _alowHBHour = 19;
var alowHBMaxNum = 2;
var hbbeginTime = 600;
var hb_max_msg = "同一候补订单中每个乘车日期最多可包含" + alowHBMaxNum + "个不同“车次+席别”的组合需求。";
var hb_date_msg = "请选择两个相邻的乘车日期。";
var hb_date_msg_station = "您已更换发到站，将清空原候补购票需求。";
var hb_date_msg_diff = "请选择两个相邻的乘车日期。";
var hbSessionKey = "_hbBuyCart";
var houbuColor_y = "#f80";
var houbuColor_n = "grey";
var isInitLoad = true; (function() {
    var a;
    var bj = null;
    var bX;
    var bI;
    var S;
    var ap;
    var cw;
    var cf;
    var q = false;
    var cm = 0;
    var aJ;
    var bu;
    var B;
    var am;
    var cD;
    var br = new Array();
    var cb = new Array();
    var cl = new Array();
    var ae = new Array();
    var b6 = new Array();
    var P;
    var aP = new Array();
    tickets_info = new Array();
    var bk = true,
    co = true,
    bf = true,
    aK = "starttime";
    var aO = true;
    var bR = [];
    var bx = [];
    var ce = [];
    var a3;
    var M = [];
    var cc = "";
    var cu = "";
    var bp = "";
    var h = "";
    var H = "";
    $(document).ready(function() {
        d();
        $.init_ul4li();
        g();
        ag();
        C();
        ak();
        K();
        aL();
        bm();
        bP();
        clickCheckBoxName();
        bV();
        cg();
        aC();
        ar();
        cq();
        E();
        be();
        b2();
        $("#float").headerFloat();
        $(window).scroll(function() {
            if (bj != null && (!bj.isHidden())) {
                $("#floatTable").hide();
                $(window).scrollTop(a)
            }
        });
        $.stopStation({
            url: ctx + "czxx/queryByTrainNo",
            getSearchDate: function() {
                return train_tour_flag == "fc" ? $.trim($("#back_train_date").val()) : $.trim($("#train_date").val())
            }
        });
        bt();
        cI();
        cr();
        p();
        Y();
        an();
        cc = $("#fromStationText").val();
        cu = $("#toStationText").val();
        $("#showOnlyTicA").bind("click",
        function() {
            $("#filterTic").attr("checked", "checked");
            by();
            $jpopup.startOrHiden()
        });
        a3 = $.autoSubmit();
        var cN = $("#train_date").val();
        var cL = $("#back_train_date").val();
        if (cL == "") {
            $("#back_train_date").val(cN)
        } else {
            $("#back_train_date").val(cL)
        }
        w();
        bc();
        var cM = new bH("right");
        cM.init();
        ac();
        if (page_show_flag == "preStep") {
            $("#query_ticket").click()
        }
        if (tour_flag == "fc" || tour_flag == "gc") {
            $(".cart-hd").hide()
        }
    });
    var bH = function(cS) {
        var cT, cP = {},
        cU, cQ = this,
        cO = false,
        cM, cR, cN = {
            x: 10,
            y: 66
        },
        cL = {
            x: 5,
            y: 1
        };
        this.move = function() {
            cM = cM + cL.x;
            cR = cR + cL.y;
            if (cM < cN.x) {
                cM = cN.x;
                cL.x = -cL.x
            } else {
                if (cM > cP.dx) {
                    cM = cP.dx;
                    cL.x = -cL.x
                }
            }
            if (cR < cN.y) {
                cR = cN.y;
                cL.y = -cL.y
            } else {
                if (cR > cP.dy) {
                    cR = cP.dy;
                    cL.y = -cL.y
                }
            }
            cU.css(cS, cM + "px").css("top", cR + "px")
        };
        this.init = function() {
            if (cO) {
                return
            }
            cO = true;
            cU = $(bH.htmlTemplate);
            $(window).on("resize", cQ.resize);
            cU.css(cS, cN.x + "px").css({
                top: cN.y + "px"
            }).on("mouseenter", cQ.stop).on("mouseleave", cQ.resize).children("a.close").on("click", cQ.hidden);
            $("body").append(cU);
            cM = cN.x;
            cR = cN.y;
            cQ.resize()
        };
        this.destory = function() {
            cU.remove()
        };
        this.resize = function() {
            cP.dx = ($(window).width() - $(".content").width()) / 2 - cU.width();
            cP.dy = ($(window).height()) - cU.height();
            if (cP.dx <= (cN.x + Math.abs(cL.x)) || cP.dy <= (cN.y + Math.abs(cL.y))) {
                cQ.stop()
            } else {
                cQ.alive()
            }
        };
        this.show = function() {
            cU.show();
            cQ.alive()
        };
        this.hidden = function() {
            cQ.stop();
            cU.hide()
        };
        this.stop = function() {
            clearInterval(cT)
        };
        this.alive = function() {
            cQ.stop();
            cT = setInterval(cQ.move, 200)
        }
    };
    function L() {
        setTimeout(function() {
            if (!frameComplete) {
                var cM = $("#ad_frame_query");
                var cL = cM.get(0);
                var cN = ctx + "resources/images/bg11.png";
                cM.remove();
                $("#myfix_yh").css("background", "url(" + cN + ") no-repeat");
                $("#myfix_yh").html('<a href="javascript:void(0);" class="close" title="关闭">关闭</a>');
                $("#myfix_yh").children("a.close").on("click",
                function() {
                    $(this).parent().hide()
                })
            }
        },
        adtimeout)
    }
    function t() {
        var cN = $(".cart-tlist li");
        if (cN && cN.length > 0) {
            for (var cM = 0; cM < cN.length; cM++) {
                var cL = $(cN[cM]).attr("hbid").split("#")[0];
                if (cL == $("#train_date").val()) {
                    $(cN[cM]).find('a[class="del"]').click()
                }
                var cP = $(cN[cM]).attr("hbid").split("#");
                var cO = cP[0] + "#" + cP[3] + "#" + cP[4] + "#";
                $('td[hbdata="' + cO + '"]').click()
            }
        }
    }
    function b3(cM) {
        if (cM) {
            $(".yzm").show();
            $("#orange_msg").hide();
            $("#randCodeForm_id").find("a").css("margin-top", "30px");
            var cL = $("#qr_submit1");
            cL.unbind("click").bind("click", j);
            cL.removeClass("btn92").addClass("btn92s").show();
            ifAlertCode = true
        } else {
            $(".yzm").hide();
            $("#orange_msg").show();
            $("#qr_submit1").hide();
            ifAlertCode = false
        }
    }
    function an() {
        if (rqChecked.length == 0) {
            if (train_tour_flag == "fc") {
                rqChecked.push($("#back_train_date").val())
            } else {
                rqChecked.push($("#train_date").val())
            }
        }
    }
    function cr() {
        if (ClickWho == "0X00") {
            $("#sf1").attr("disabled", "true");
            $("#sf1_label").addClass("color999");
            $("#sf2").attr("checked", "true");
            $("#query_ticket").removeClass().addClass("btn92s")
        } else {
            if (ClickWho == "00" || ClickWho == "ADULT") {
                $("#sf2").attr("disabled", "true");
                $("#sf2_label").addClass("color999");
                $("#query_ticket").removeClass().addClass("btn92s")
            } else {
                $("#query_ticket").removeClass().addClass("btn92s")
            }
        }
        if (isstudentDate) {
            $("#sf2").attr("disabled", "true");
            $("#sf2_label").addClass("color999");
            $("#query_ticket").removeClass().addClass("btn92s")
        }
    }
    function at() {
        if (!isInitStationDiv) {
            e();
            isInitStationDiv = true
        }
        if (!isInitJsrenderTemplate) {
            aE();
            isInitJsrenderTemplate = true
        }
    }
    function bt() {
        $("#fromStationText").mouseover(at);
        $("#toStationText").mouseover(at);
        $("#dc").mouseover(at);
        $("#wf").mouseover(at);
        $("#dc_label").mouseover(at);
        $("#wf_label").mouseover(at);
        $("#train_date").mouseover(at);
        $("#back_train_date").mouseover(at);
        $("#date_range").mouseover(at)
    }
    
    function aN(cL) {
        aZ();
        var cS = b6.length;
        if ($("#query_ticket").html() == "停止查询") {
            if (cS > 0 && a5) {
                $("#auto_query").removeAttr("disabled");
                if ($("#dc").is(":checked") && train_tour_flag != "gc") {
                    $("#autoSubmit").removeAttr("disabled");
                    $("#partSubmit").removeAttr("disabled")
                }
                $("#query_ticket").html("查询");
                $("#query_ticket").unbind("click");
                b7();
                if (countDown) {
                    clearInterval(countDown)
                }
                $("#filterTicDiv").html("<strong><label for='filterTic' style='cursor: pointer;'>仅显示选定车次</label></strong>");
                if (!$("#autoSubmit").is(":checked")) {
                    clearInterval(bh);
                    if (ccSelected.length > 0 || rqChecked.length > 0 || xbChecked.length > 0) {
                        myJpopup.startOrHiden();
                        if (train_tour_flag == "fc") {
                            var cT = "成功查到" + $("#back_train_date").val() + "的" + b6[0]["queryLeftNewDTO"]["station_train_code"] + "次"
                        } else {
                            var cT = "成功查到" + $("#train_date").val() + "的" + b6[0]["queryLeftNewDTO"]["station_train_code"] + "次"
                        }
                        if (cS == 1) {
                            cT = cT + "车。"
                        } else {
                            cT = cT + "等" + cS + "趟车。"
                        }
                        $("#filterRes").html(cT)
                    }
                }
                jPlayer("play")
            } else {
                if (countDown) {
                    clearInterval(countDown)
                }
                var cR = autoSearchTime / 1000;
                $("#filterTicDiv").html("<strong>离下次刷新时间<font class='colorA' style='font-size: 16px;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + cR + "</font>秒<strong>");
                countDown = window.setInterval(function() {
                    var cU = "<strong>离下次刷新时间<font class='colorA' style='font-size: 16px;'>";
                    if (cR == 0) {
                        cR = autoSearchTime / 1000
                    }
                    cR = cR - 1;
                    if (cR == 4) {
                        cU = cU + "&nbsp;&nbsp;&nbsp;&nbsp;"
                    }
                    if (cR == 3) {
                        cU = cU + "&nbsp;&nbsp;&nbsp;"
                    }
                    if (cR == 2) {
                        cU = cU + "&nbsp;&nbsp;"
                    }
                    if (cR == 1) {
                        cU = cU + "&nbsp;"
                    }
                    cU = cU + cR;
                    cU += "</font>秒<strong>";
                    $("#filterTicDiv").html(cU)
                },
                1000);
                $("#filterTic").hide()
            }
        }
        var cQ = new Array();
        cQ.push('<tbody id="queryLeftTable">');
        cL = a7(cL);
        var cN = ci(cL);
        if (cN) {
            cL = cz(cL)
        }
        if ($("#avail_jf")[0].checked) {
            cL = aU(cL)
        }
        for (var cM = 0; cM < cL.length; cM++) {
            cQ.push('<tr id="ticket_');
            cQ.push(cL[cM].queryLeftNewDTO.train_no);
            cQ.push('" class="');
            cQ.push(cM % 2 ? '">': 'bgc">');
            cQ.push('<td colspan="4" width="370">');
            cQ.push('<div class="ticket-info clearfix" id="train_num_');
            cQ.push(cM);
            cQ.push('">');
            cQ.push('<div class="train" id="ticket_');
            cQ.push(cL[cM].queryLeftNewDTO.train_no);
            cQ.push('_train">');
            var cP = "";
            if (c(cL[cM].queryLeftNewDTO.station_train_code)) {
                cP = ' style="color:red;" '
            }
            cQ.push("<div><a  " + cP + ' title="点击查看停靠站信息" href="javascript:" id="');
            cQ.push(cL[cM].queryLeftNewDTO.train_no);
            cQ.push("_");
            cQ.push(cL[cM].queryLeftNewDTO.from_station_telecode);
            cQ.push("_");
            cQ.push(cL[cM].queryLeftNewDTO.to_station_telecode);
            if ("1" == cL[cM].queryLeftNewDTO.controlled_train_flag || "2" == cL[cM].queryLeftNewDTO.controlled_train_flag) {
                cQ.push('" class="number"');
                cQ.push(">")
            } else {
                cQ.push('" class="number"  onclick="myStopStation.open(\'');
                cQ.push(cM);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.train_no);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.from_station_telecode);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.to_station_telecode);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.start_train_date);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.train_seat_feature);
                cQ.push("');\">")
            }
            cQ.push(cL[cM].queryLeftNewDTO.station_train_code);
            cQ.push("</a>");
            if (cL[cM].queryLeftNewDTO.is_support_card != 0) {
                cQ.push(' <span class="i-card" title="可凭二代身份证直接进出站"></span>')
            }
            cQ.push("</div>");
            cQ.push('<span id="');
            cQ.push(cL[cM].queryLeftNewDTO.train_no);
            cQ.push("_");
            cQ.push(cL[cM].queryLeftNewDTO.from_station_no);
            cQ.push("_");
            cQ.push(cL[cM].queryLeftNewDTO.to_station_no);
            cQ.push("_");
            cQ.push(cL[cM].queryLeftNewDTO.yp_info);
            cQ.push("_");
            cQ.push(cL[cM].queryLeftNewDTO.seat_types);
            if ("1" == cL[cM].queryLeftNewDTO.controlled_train_flag || "2" == cL[cM].queryLeftNewDTO.controlled_train_flag) {
                cQ.push('" class="lookup"><span style="display:none;">查看票价</span><b style="display:none;" title="查看票价"></b></span>')
            } else {
                cQ.push('" class="lookup" onclick="showTicketPrice(this)"><span style="display:none;">查看票价</span><b title="查看票价"></b></span>')
            }
            cQ.push("</div>");
            cQ.push('<div class="cdz">');
            if (cL[cM].queryLeftNewDTO.from_station_telecode != null && cL[cM].queryLeftNewDTO.from_station_telecode == cL[cM].queryLeftNewDTO.start_station_telecode) {
                cQ.push('<strong class="start-s">');
                cQ.push(cL[cM].queryLeftNewDTO.from_station_name);
                cQ.push("</strong>")
            } else {
                cQ.push("<strong>");
                cQ.push(cL[cM].queryLeftNewDTO.from_station_name);
                cQ.push("</strong>")
            }
            if (cL[cM].queryLeftNewDTO.to_station_telecode != null && cL[cM].queryLeftNewDTO.to_station_telecode == cL[cM].queryLeftNewDTO.end_station_telecode) {
                cQ.push('<strong class="end-s">');
                cQ.push(cL[cM].queryLeftNewDTO.to_station_name);
                cQ.push("</strong>")
            } else {
                cQ.push("<strong>");
                cQ.push(cL[cM].queryLeftNewDTO.to_station_name);
                cQ.push("</strong>")
            }
            cQ.push("</div>");
            cQ.push('<div class="cds">');
            if ("1" == cL[cM].queryLeftNewDTO.controlled_train_flag || "2" == cL[cM].queryLeftNewDTO.controlled_train_flag) {
                cQ.push('<strong class="start-t" style="color:#999;">');
                cQ.push("-----");
                cQ.push("</strong>");
                cQ.push('<strong class="color999">');
                cQ.push("-----");
                cQ.push("</strong>")
            } else {
                cQ.push('<strong class="start-t">');
                cQ.push(cL[cM].queryLeftNewDTO.start_time);
                cQ.push("</strong>");
                cQ.push('<strong class="color999">');
                cQ.push(cL[cM].queryLeftNewDTO.arrive_time);
                cQ.push("</strong>")
            }
            cQ.push("</div>");
            cQ.push('<div  class="ls" ');
            cQ.push('id="');
            cQ.push(cL[cM].queryLeftNewDTO.train_no);
            cQ.push('_ls">');
            if ("1" == cL[cM].queryLeftNewDTO.controlled_train_flag || "2" == cL[cM].queryLeftNewDTO.controlled_train_flag) {
                cQ.push('<strong class="color999">');
                cQ.push("------");
                cQ.push("</strong>");
                cQ.push('<strong class="color999">');
                cQ.push("------");
                cQ.push("</strong>")
            } else {
                cQ.push("<strong>");
                cQ.push(cL[cM].queryLeftNewDTO.lishi);
                cQ.push("</strong>");
                cQ.push("<span>");
                cQ.push(changeArriveDate(cL[cM].queryLeftNewDTO.start_time, cL[cM].queryLeftNewDTO.lishi));
                cQ.push("到达</span>")
            }
            cQ.push("</div>");
            cQ.push("</div>");
            cQ.push("</td>");
            if (cL[cM].queryLeftNewDTO.swz_num && cL[cM].queryLeftNewDTO.swz_num != "--" && cL[cM].queryLeftNewDTO.swz_num != 0 && cL[cM].queryLeftNewDTO.swz_num != "无") {
                cs(cQ, cL[cM].queryLeftNewDTO.swz_num, "SWZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "91", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM])
            } else {
                if (cL[cM].queryLeftNewDTO.tz_num && cL[cM].queryLeftNewDTO.tz_num != "--" && cL[cM].queryLeftNewDTO.tz_num != 0 && cL[cM].queryLeftNewDTO.tz_num != "无") {
                    cs(cQ, cL[cM].queryLeftNewDTO.tz_num, "TZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "P1", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM])
                } else {
                    if (cL[cM].queryLeftNewDTO.swz_num && cL[cM].queryLeftNewDTO.swz_num == "无") {
                        cs(cQ, cL[cM].queryLeftNewDTO.swz_num, "SWZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "91", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM])
                    } else {
                        cs(cQ, cL[cM].queryLeftNewDTO.tz_num, "TZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "P1", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM])
                    }
                }
            }
            cs(cQ, cL[cM].queryLeftNewDTO.zy_num, "ZY_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "M1", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.ze_num, "ZE_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "O1", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.gr_num, "GR_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "61", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.rw_num, "RW_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "41", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.srrb_num, "SRRB_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "F1", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.yw_num, "YW_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "31", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.rz_num, "RZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "21", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.yz_num, "YZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "11", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.wz_num, "WZ_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "W1", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            cs(cQ, cL[cM].queryLeftNewDTO.qt_num, "QT_", cL[cM].queryLeftNewDTO.train_no, cL[cM].queryLeftNewDTO.yp_ex, "", cL[cM].queryLeftNewDTO.controlled_train_flag, cL[cM]);
            if ("Y" == cL[cM].queryLeftNewDTO.canWebBuy) {
                cQ.push(' <td align="center" width="80" class="no-br"><a href="javascript:" class="btn72" onclick="checkG1234(\'');
                cQ.push(cL[cM].secretStr);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.start_time);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.train_no);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.from_station_telecode);
                cQ.push("','");
                cQ.push(cL[cM].queryLeftNewDTO.to_station_telecode);
                cQ.push("')\">");
                cQ.push(buttonText());
                if (cL[cM].queryLeftNewDTO.exchange_train_flag == 1) {
                    cQ.push("<i class='ico-dh'></i>")
                }
                cQ.push("</a>");
                cQ.push("</td>")
            } else {
                cQ.push('<td align="center" width="80" class="no-br">');
                cQ.push(cL[cM].buttonTextInfo);
                cQ.push("</td>")
            }
            cQ.push("</tr>");
            cQ.push('<tr datatran="' + cL[cM].queryLeftNewDTO.station_train_code + '" id="price_');
            cQ.push(cL[cM].queryLeftNewDTO.train_no);
            cQ.push('" style="display:none;"></tr>')
        }
        cQ.push("</tbody>");
        $("#queryLeftTable").replaceWith(cQ.join(""));
        if (cN) {
            for (var cM = 0; cM < cL.length; cM++) {
                var cO = cL[cM];
                if (c(cO.queryLeftNewDTO.station_train_code)) {}
            }
        }
    }
    function cz(cM) {
        if (cM && cM.length > 0) {
            var cQ = [];
            var cL = [];
            for (var cN = 0,
            cO = cM.length; cN < cO; cN++) {
                var cP = cM[cN];
                if (c(cP.queryLeftNewDTO.station_train_code)) {
                    cQ.push(cP)
                } else {
                    cL.push(cP)
                }
            }
            cM = cQ.concat(cL)
        }
        return cM
    }
    function aU(cL) {
        if (cL && cL.length > 0) {
            for (var cM = cL.length - 1; cM >= 0; cM--) {
                if (cL[cM].queryLeftNewDTO.exchange_train_flag == 0 || cL[cM].queryLeftNewDTO.canWebBuy != "Y") {
                    cL.splice(cM, 1)
                }
            }
        }
        return cL
    }
    function a7(cL) {
        if (cL && cL.length > 0) {
            var cR = [];
            var cM = [];
            for (var cN = 0,
            cT = cL.length; cN < cT; cN++) {
                var cP = cL[cN];
                var cQ = cP.queryLeftNewDTO.yp_ex.split("");
                var cS = false;
                for (var cO = 0; cO < cQ.length; cO++) {
                    if (cO % 2 == 1 && cQ[cO] == 1) {
                        cS = true;
                        break
                    }
                }
                if (cS) {
                    cR.push(cP)
                } else {
                    cM.push(cP)
                }
            }
            cL = cR.concat(cM)
        }
        return cL
    }
    function c(cN) {
        if (DW_TRAINS && DW_TRAINS.length) {
            for (var cL = 0,
            cM = DW_TRAINS.length; cL < cM; cL++) {
                if (cN == DW_TRAINS[cL]) {
                    return true
                }
            }
        } else {
            return false
        }
        return false
    }
    function ci(cL) {
        if (cL && cL.length > 0) {
            if (DW_TRAINS && DW_TRAINS.length) {
                for (var cO = 0,
                cQ = cL.length; cO < cQ; cO++) {
                    var cP = cL[cO].queryLeftNewDTO.station_train_code;
                    for (var cM = 0,
                    cN = DW_TRAINS.length; cM < cN; cM++) {
                        if (cP == DW_TRAINS[cM]) {
                            return true
                        }
                    }
                }
            }
        }
        return false
    }
    function ao(cR, cL) {
        var cS, cP, cO;
        var cN;
        cO = cR["leftTicketDTO.train_date"];
        if (hainan_limit_start_traindate && G(cO) >= G(hainan_limit_start_traindate)) {
            if (hainan_limit_from_telcode && hainan_limit_to_telcode) {
                for (var cM = 0,
                cQ = cL.length; cM < cQ; cM++) {
                    cS = cL[cM].queryLeftNewDTO.from_station_telecode;
                    cP = cL[cM].queryLeftNewDTO.to_station_telecode;
                    cN = cL[cM].buttonTextInfo;
                    if (hainan_limit_from_telcode.indexOf(cS) > -1 && hainan_limit_to_telcode.indexOf(cP) > -1 && cN.indexOf("起售") > -1) {
                        return true
                    }
                }
            }
        }
        return false
    }
    function b0(cQ) {
        var cM = new Date();
        cM.setHours(cM.getHours() + 3);
        var cO = cM.getTime();
        var cP = new Date(cQ.replace(/-/g, "/")).getTime();
        if (cP <= cO) {
            return false
        }
        var cN = cQ.substring(0, 10).replace(/-/g, "");
        var cL = other_buy_date.split("&")[1].replace(/-/g, "");
        if (cN > cL) {
            return false
        }
        return true
    }
    function aq(cM) {
        var cN = "";
        var cL = new Date();
        cL.setDate(cL.getDate() + cM);
        cN += cL.getFullYear() + "-";
        cN += ai((cL.getMonth() + 1)) + "-";
        cN += ai((cL.getDate()));
        return cN
    }
    function ai(cL) {
        var cM = cL + "";
        if (cM.length < 2) {
            cM = "0" + cM
        }
        return cM
    }
    function Z(cL) {
        if (cL == "SWZ_") {
            return "9"
        } else {
            if (cL == "TZ_") {
                return "P"
            } else {
                if (cL == "ZY_") {
                    return "M"
                } else {
                    if (cL == "ZE_") {
                        return "O"
                    } else {
                        if (cL == "GR_") {
                            return "6"
                        } else {
                            if (cL == "RW_") {
                                return "4"
                            } else {
                                if (cL == "SRRB_") {
                                    return "F"
                                } else {
                                    if (cL == "YW_") {
                                        return "3"
                                    } else {
                                        if (cL == "RZ_") {
                                            return "2"
                                        } else {
                                            if (cL == "YZ_") {
                                                return "1"
                                            } else {
                                                if (cL == "WZ_") {
                                                    return ""
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return ""
    }
    function cs(cU, c8, c4, cZ, c5, cW, cS, cV) {
        var cN = cV.queryLeftNewDTO;
        var cQ = $("#train_date").val() + "#" + cN.from_station_telecode + "#" + cN.to_station_telecode + "#" + cN.train_no + "#" + c4 + "#" + cN.from_station_no + "#" + cN.from_station_name + "#" + cN.to_station_no + "#" + cN.to_station_name + "#" + cV.secretStr + "#" + cN.station_train_code + "#";
        var cM = $("#train_date").val() + "#" + cN.train_no + "#" + c4 + "#";
        var cY = "";
        var c0 = b0($("#train_date").val() + " " + cN.start_time);
        if ($("#train_date").val() == aq(0)) {
            c0 = false
        }
        var cO = new Date().getHours();
        if (cO >= _alowHBHour) {
            if ($("#train_date").val() == aq(1)) {
                c0 = false
            }
            if ($("#train_date").val() == aq(2)) {
                var cP = cN.start_time;
                var cT = cP.substring(0, 2) + cP.substring(3, 5);
                if (cT < hbbeginTime) {
                    c0 = false
                }
            }
        }
        if ($("#train_date").val() == aq(1)) {
            var cP = cN.start_time;
            var cT = cP.substring(0, 2) + cP.substring(3, 5);
            if (cT < hbbeginTime) {
                c0 = false
            }
        }
        if (!cV.secretStr || "null" == cV.secretStr) {
            c0 = false
        }
        if (tour_flag == "fc" || tour_flag == "gc") {
            c0 = false
        }
        if (!"1" == cN.houbu_train_flag) {
            c0 = false
        }
        var c6 = "1";
        var cX = "";
        if ("无" == c8 && "WZ_" != c4 && "QT_" != c4 && c0) {
            c8 = "候补";
            var c1 = Z(c4);
            if (c1 != "" && cN.houbu_seat_limit && cN.houbu_seat_limit.indexOf(c1) > -1) {
                cY = "color: " + houbuColor_n + ";";
                c6 = "0";
                cX = "当前席别候补需求提交人数较多，请更换其他车次或席别"
            } else {
                cY = "color: " + houbuColor_y + ";"
            }
        }
        c5 = c5.replace("A", "6");
        var c7 = c5 ? c5.indexOf(cW) : -1;
        var c3 = false;
        if (c7 > -1 && (c7 % 2) == 0) {
            c3 = true
        }
        if (cW == "") {
            c3 = false;
            var cL = c5.split("");
            for (var c2 = 0; c2 < cL.length; c2++) {
                if (c2 % 2 == 0 && cL[c2] != "9" && cL[c2] != "P" && cL[c2] != "M" && cL[c2] != "O" && cL[c2] != "6" && cL[c2] != "4" && cL[c2] != "F" && cL[c2] != "3" && cL[c2] != "2" && cL[c2] != "1" && cL[c2] != "W") {
                    if (cL[c2 + 1] == "1") {
                        c3 = true;
                        break
                    }
                }
            }
        }
        if ("1" == cS || "2" == cS) {
            cU.push(' <td width="46" align="center" style="cursor: pointer;"  id="');
            cU.push(c4);
            cU.push(cZ);
            cU.push('">');
            cU.push(c8);
            cU.push("</td>")
        } else {
            if ("有" == c8) {
                if (c4 == "SWZ_" || c4 == "TZ_") {
                    cU.push('<td hbdata="' + cM + '" hbid="' + cQ + '" width="46" align="center" class="yes" onclick="showTicketPrice(this)"　style="cursor: pointer;" id="');
                    cU.push(c4);
                    cU.push(cZ);
                    cU.push('">');
                    if (c3) {
                        cU.push('<div class="sale" title="本席别票价打折">' + c8 + '<span class="i-mark">折</span></div>')
                    } else {
                        cU.push(c8)
                    }
                    cU.push("</td>")
                } else {
                    if (c4 == "ZY_" || c4 == "ZE_") {
                        cU.push('<td hbdata="' + cM + '" hbid="' + cQ + '" width="46" align="center" class="yes" style="cursor: pointer;" onclick="showTicketPrice(this)" id="');
                        cU.push(c4);
                        cU.push(cZ);
                        cU.push('">');
                        if (c3) {
                            cU.push('<div class="sale" title="本席别票价打折">' + c8 + '<span class="i-mark">折</span></div>')
                        } else {
                            cU.push(c8)
                        }
                        cU.push("</td>")
                    } else {
                        cU.push('<td hbdata="' + cM + '" hbid="' + cQ + '" width="46" align="center" style="cursor: pointer;" class="yes" onclick="showTicketPrice(this)" id="');
                        cU.push(c4);
                        cU.push(cZ);
                        cU.push('">');
                        if (c3) {
                            cU.push('<div class="sale" title="本席别票价打折">' + c8 + '<span class="i-mark">折</span></div>')
                        } else {
                            cU.push(c8)
                        }
                        cU.push("</td>")
                    }
                }
            } else {
                if (c8 == "无" || isNum(c8) >= 0) {
                    var cR = ' class="t-num" ';
                    if (c8 == "无" || isNum(c8) == 0) {
                        cR = ""
                    }
                    if (c4 == "SWZ_" || c4 == "TZ_" || c4 == "ZY_" || c4 == "ZE_") {
                        cU.push('<td title="' + cX + '" ifAlow_MaxLength="' + c6 + '" hbdata="' + cM + '"  hbid="' + cQ + '" width="46" align="center" style="cursor: pointer;' + cY + '" ' + cR + ' onclick="showTicketPrice(this)" id="');
                        cU.push(c4);
                        cU.push(cZ);
                        cU.push('">');
                        cU.push("<div>");
                        if (c3) {
                            cU.push('<div class="sale" title="本席别票价打折">' + c8 + '<span class="i-mark">折</span></div>')
                        } else {
                            cU.push(c8)
                        }
                        cU.push("</td>")
                    } else {
                        cU.push('<td title="' + cX + '" ifAlow_MaxLength="' + c6 + '" hbdata="' + cM + '" hbid="' + cQ + '" width="46" align="center" style="cursor: pointer;' + cY + '" ' + cR + ' onclick="showTicketPrice(this)" id="');
                        cU.push(c4);
                        cU.push(cZ);
                        cU.push('">');
                        if (c3) {
                            cU.push('<div class="sale" title="本席别票价打折">' + c8 + '<span class="i-mark">折</span></div>')
                        } else {
                            cU.push(c8)
                        }
                        cU.push("</td>")
                    }
                } else {
                    cU.push(' <td title="' + cX + '" ifAlow_MaxLength="' + c6 + '" hbdata="' + cM + '" hbid="' + cQ + '" width="46" align="center" style="cursor: pointer;' + cY + '" ' + cR + ' onclick="showTicketPrice(this)"  id="');
                    cU.push(c4);
                    cU.push(cZ);
                    cU.push('">');
                    cU.push(c8);
                    cU.push("</td>")
                }
            }
        }
    }
    function l(cM, cL) {
        ishaveCheckId = false;
        for (i = 0; i < cM.length; i++) {
            if (cM[i][0] == cL) {
                cM[i][1] = $("#".concat($("#".concat(cL)).attr("for"))).is(":checked");
                ishaveCheckId = true
            }
        }
        if (!ishaveCheckId) {
            cM[cM.length] = [cL, true]
        }
    }
    function b9() {
        f(bX);
        f(bI);
        f(S)
    }
    function f(cL) {
        for (i = 0; i < cL.length; i++) {
            if (cL[i][1]) {
                $("#".concat(cL[i][0]).concat("_check")).attr("checked", true)
            }
        }
    }
    function G(cM) {
        var cL = new Date();
        var cN = cM.split("-");
        cL.setFullYear(parseInt(cN[0]), parseInt(cN[1] - 1, 10), parseInt(cN[2], 10));
        if (cN.length >= 6) {
            cL.setHours(cN[3], cN[4], cN[5])
        }
        return cL
    }
    Date.prototype.format = function(cM) {
        var cN = {
            "M+": this.getMonth() + 1,
            "d+": this.getDate(),
            "h+": this.getHours(),
            "m+": this.getMinutes(),
            "s+": this.getSeconds(),
            "q+": Math.floor((this.getMonth() + 3) / 3),
            S: this.getMilliseconds()
        };
        if (/(y+)/.test(cM)) {
            cM = cM.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length))
        }
        for (var cL in cN) {
            if (new RegExp("(" + cL + ")").test(cM)) {
                cM = cM.replace(RegExp.$1, RegExp.$1.length == 1 ? cN[cL] : ("00" + cN[cL]).substr(("" + cN[cL]).length))
            }
        }
        return cM
    };
    function aX(cN, cM) {
        var cL = new Date(Date.parse(cN.replace(/-/g, "/")));
        cL.setDate(cL.getDate() + cM);
        return W(cL)
    }
    function W(cM) {
        var cN = cM.getFullYear();
        var cP = cM.getMonth() + 1;
        var cO = cM.getDate();
        var cL = cN + "-" + cP + "-" + cO;
        return cL
    }
    function bY() {
        var cN = $("#train_date").val();
        var cM = $("#back_train_date").val();
        var cL = false;
        if ($("#wf").is(":checked")) {
            if (G(cN) <= G(cM)) {
                cL = true
            }
        } else {
            return true
        }
        return cL
    }
    function cB() {
        var cO = $.jc_getFromStation();
        if (cO) {
            var cN = cO.split(",");
            if (cN && cN.length == 2) {
                $("#fromStationText").val(cN[0]);
                $("#fromStation").val(cN[1])
            }
        }
        var cM = $.jc_getToStation();
        if (cM) {
            var cN = cM.split(",");
            if (cN && cN.length == 2) {
                $("#toStationText").val(cN[0]);
                $("#toStation").val(cN[1])
            }
        }
        var cP = [];
        cP = stu_buy_date.split("&");
        var cL = $.jc_getFromDate();
        if (cL) {
            if (cL >= cP[0] && cL <= cP[1]) {
                $("#train_date").val(cL)
            }
        }
        var cQ = $.jc_getWfOrDc();
        if (cQ && "wf" == cQ) {
            $("#wf").click();
            var cR = $.jc_getToDate();
            if (cR) {
                if (cR >= cP[0] && cR <= cP[1]) {
                    $("#back_train_date").val(cR)
                }
            }
        } else {
            $("#dc").click()
        }
    }
    function bi() {
        $("#train_stop").on("mouseover",
        function(cL) {
            if (checkHover(cL, this)) {
                cm = 1
            }
        }).on("mouseleave",
        function() {
            cm = 0;
            $("#train_stop").hide();
            $("#train_table_").html("")
        })
    }
    function g() {
        fromStation = from_station;
        fromStationName = from_station_name;
        toStation = to_station;
        toStationName = to_station_name;
        trainDate = trainDate;
        backTrainDate = backTrainDate;
        bX = new Array();
        bI = new Array();
        S = new Array()
    }
    function w() {
        if ($("#sf1").is(":checked")) {
            isOther = true;
            if (other_control < dataNumber) {
                for (var cL = other_control + 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").hide()
                }
            } else {
                for (var cL = 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").show()
                }
            }
        } else {
            isOther = false;
            if (stu_control < dataNumber) {
                for (var cL = stu_control + 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").hide()
                }
            } else {
                for (var cL = 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").show()
                }
            }
        }
    }
    function p() {
        $("#fromStation").val(fromStation);
        $("#fromStationText").val(fromStationName);
        $("#toStation").val(toStation);
        $("#toStationText").val(toStationName);
        $("#train_date").val(trainDate);
        if (isInMaintenanceHours) {
            if (!isSuperLogin) {
                $("#autoSubmit").prop("checked", false);
                $("#autoSubmit").attr("disabled", true);
                $("#autoSubmit").siblings("label").css("color", "#999");
                $("#autoSubmitTxt").attr("title", "系统维护时间下不允许自动提交");
                $("#partSubmit").prop("checked", false);
                $("#partSubmit").attr("disabled", true);
                $("#partSubmit").siblings("label").css("color", "#999");
                $("#partSubmitTxt").attr("title", "系统维护时间下不允许自动提交");
                $("#auto_query").prop("checked", false);
                $("#auto_query").attr("disabled", true);
                $("#auto_query").siblings("label").css("color", "#999");
                $("#autoQueryTxt").attr("title", "系统维护时间下不允许自动查询")
            }
        }
        if (backTrainDate != null && backTrainDate != "") {
            $("#back_train_date").val(backTrainDate)
        }
        if ($("#fromStationText").val() == "") {
            $("#fromStationText").val("简拼/全拼/汉字")
        }
        if ($("#toStationText").val() == "") {
            $("#toStationText").val("简拼/全拼/汉字")
        }
        if (page_show_flag == null) {
            cB();
            aI()
        } else {
            if (page_show_flag == "index") {
                bG()
            } else {
                if (page_show_flag == "preStep") {
                    cv()
                } else {
                    if (page_show_flag == "fcInit") {
                        z();
                        $("#autoSubmit").attr("disabled", true);
                        $("#autoSubmit").siblings("label").css("color", "#999");
                        $("#partSubmit").attr("disabled", true);
                        $("#partSubmit").siblings("label").css("color", "#999")
                    } else {
                        if (page_show_flag == "gcInit") {
                            bJ();
                            $("#autoSubmit").attr("disabled", true);
                            $("#autoSubmit").siblings("label").css("color", "#999");
                            $("#partSubmit").attr("disabled", true);
                            $("#partSubmit").siblings("label").css("color", "#999")
                        }
                    }
                }
            }
        }
    }
    function bG() {
        if (tour_flag == "wf") {
            $("#wf").click()
        } else {
            if (tour_flag == "dc") {
                $("#dc").click()
            }
        }
        if (purposeCodeFromIndex == "0X00") {
            $("#sf2").click()
        } else {
            if (purposeCodeFromIndex == "ADULT") {
                $("#sf1").click()
            }
        }
        var cL = [];
        $("#date_range>ul>li").each(function() {
            var cM = $(this).children("span:first-child").html();
            cL.push(cM)
        });
        $("#query_ticket").click()
    }
    function aI() {
        var cO = decodeURI(window.location.href);
        value = cO.split("?")[1];
        if (value != "" && value != undefined && value != "undefined") {
            var cP = initParams(value);
            if (cP.linktypeid) {
                if ("dc" == cP.linktypeid) {
                    $("#dc").click()
                } else {
                    $("#wf").click();
                    var cM = $("#train_date").val();
                    var cN = $("#back_train_date").val();
                    if (!cN | G(cM) > G(cN)) {
                        $("#back_train_date").val(cM)
                    }
                }
            }
            if (cP.fromStationText) {
                $("#fromStationText").val(cP.fromStationText)
            }
            if (cP.fromStation) {
                $("#fromStation").val(cP.fromStation)
            }
            if (cP.toStationText) {
                $("#toStationText").val(cP.toStationText)
            }
            if (cP.toStation) {
                $("#toStation").val(cP.toStation)
            }
            if (cP.train_date) {
                $("#train_date").val(cP.train_date)
            }
            if (cP.back_train_date) {
                $("#back_train_date").val(cP.back_train_date)
            }
            if (cP.is_student && "Y" == cP.is_student) {
                $("#sf2").click()
            } else {
                $("#sf1").click()
            }
            if (cP.is_GDC && "Y" == cP.is_GDC) {
                $("#sear-sel-bd input[name='cc_type']")[0].click();
                $("#sear-sel-bd input[name='cc_type']")[1].click()
            }
            if (cP.auto_query && "Y" == cP.auto_query) {
                var cL = [];
                $("#date_range>ul>li").each(function() {
                    var cQ = $(this).children("span:first-child").html();
                    cL.push(cQ)
                });
                $("#query_ticket").click()
            }
        }
    }
    function cv() {
        $("#fromStationText").removeClass().addClass("inp_selected");
        $("#toStationText").removeClass().addClass("inp_selected");
        if (train_tour_flag == "dc") {
            aD(trainDate);
            $("#dc").click()
        }
        if (train_tour_flag == "wc") {
            aD(trainDate);
            $("#wf").click()
        }
        if (train_tour_flag == "fc") {
            aD(backTrainDate);
            $("#wf").click();
            $("#wf").attr("disabled", "true");
            $("#dc").attr("disabled", "true");
            $("#change_station").removeClass().addClass("i-change i-change2");
            $("#change_station").attr("style", "");
            $("#fromStationText").attr("title", "返程时不得变更出发地或不能变更到达地");
            $("#toStationText").attr("title", "返程时不得变更出发地或不能变更到达地");
            $("#toStationText").unbind("focus").unbind("click").attr("readonly", "true");
            $("#fromStationText").unbind("focus").unbind("click").attr("readonly", "true");
            $("#dfc>ul>li:nth-child(2)").children("label:first").removeClass().addClass("color999");
            $("#dfc>ul>li:nth-child(1)").children("label:first").removeClass().addClass("color999");
            $("#place_area>ul>li:nth-child(1)").addClass("no-change");
            $("#place_area>ul>li:nth-child(3)").addClass("no-change");
            $("#place_area>ul>li:nth-child(4)").addClass("no-change");
            $("#fromStationText").removeClass().addClass("inp-txt");
            $("#toStationText").removeClass().addClass("inp-txt");
            $("#change_station").unbind();
            $("#train_date").val(trainDate);
            $("#train_date").attr("readonly", "true");
            $("#train_date").removeClass().addClass("inp-txt");
            $("#train_date").unbind("click");
            $("#date_icon_1").unbind("click");
            $("#date_area>ul>li:nth-child(1)>span>label").addClass("color999");
            $("#back_train_date").val(backTrainDate);
            $("#back_train_date").removeAttr("disabled");
            $("#date_area>ul>li:nth-child(2)>span>label").removeClass("color999");
            $("#back_train_date").removeClass().addClass("inp_selected");
            $("#autoSubmit").attr("disabled", true);
            $("#autoSubmit").siblings("label").css("color", "#999");
            $("#partSubmit").attr("disabled", true);
            $("#partSubmit").siblings("label").css("color", "#999")
        }
        if (train_tour_flag == "gc") {
            aD(trainDate);
            bJ();
            $("#autoSubmit").attr("disabled", true);
            $("#autoSubmit").siblings("label").css("color", "#999");
            $("#partSubmit").attr("disabled", true);
            $("#partSubmit").siblings("label").css("color", "#999")
        }
    }
    function aD(cN) {
        for (var cL = 1; cL <= 20; cL++) {
            var cM = $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").text();
            cM = "2013-" + cM;
            if (cN == cM) {
                $("#date_range>ul>li").removeClass("sel");
                $("#date_range>ul>li").removeAttr("alt");
                $("#date_range>ul>li:nth-child(" + cL + ")").addClass("sel");
                $("#date_range>ul>li:nth-child(" + cL + ")").attr("alt", "show");
                $("#date_range>ul>li:nth-child(20)").addClass("end");
                $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").removeClass();
                $("#date_range>ul>li:nth-child(" + cL + ")").children("span:last-child").removeClass();
                $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").addClass("hide");
                $("#date_range>ul>li:nth-child(1)").children().addClass("first");
                cf = $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").text();
                break
            }
        }
    }
    function bJ() {
        $("#fromStationText").attr("title", "改签时不得变更出发地或不能变更到达地");
        $("#dc").click();
        $("#wf").attr("disabled", "true");
        $("#dc").attr("disabled", "true");
        $("#place_area>ul>li:nth-child(1)").addClass("no-change");
        $("#place_area>ul>li:nth-child(3)").addClass("no-change");
        $("#place_area>ul>li:nth-child(5)").addClass("no-change");
        $("#dfc>ul>li:nth-child(1)").children("label:first").removeClass().addClass("color999");
        $("#dfc>ul>li:nth-child(2)").children("label:first").removeClass().addClass("color999");
        $("#fromStationText").unbind("focus").unbind("click").attr("readonly", "true");
        if ("Y" != canChangeToStation) {
            $("#toStationText").unbind("focus").unbind("click").attr("readonly", "true");
            $("#toStationText").removeClass().addClass("inp-txt");
            $("#toStationText_label").addClass("color999")
        }
        $("#fromStationText").removeClass().addClass("inp-txt");
        $("#fromStationText_label").addClass("color999");
        $("#change_station").unbind();
        $("#change_station").removeClass().addClass("i-change i-change2");
        $("#change_station").attr("style", "")
    }
    function z() {
        $("#fromStationText").attr("title", "订返程票时不得变更出发地或不能变更到达地");
        $("#toStationText").attr("title", "订返程票时不得变更出发地或不能变更到达地");
        aD(backTrainDate);
        $("#wf").click();
        $("#dc").attr("disabled", "true");
        $("#wf").attr("disabled", "true");
        $("#place_area>ul>li:nth-child(1)").addClass("no-change");
        $("#place_area>ul>li:nth-child(3)").addClass("no-change");
        $("#place_area>ul>li:nth-child(4)").addClass("no-change");
        $("#dfc>ul>li:nth-child(1)").children("label:first").removeClass().addClass("color999");
        $("#dfc>ul>li:nth-child(2)").children("label:first").removeClass().addClass("color999");
        $("#train_date").attr("readonly", "true");
        $("#train_date").addClass("color999");
        $("#train_date").attr("disabled", true);
        $("#train_date").unbind("click");
        $("#date_icon_1").unbind("click");
        $("#date_area>ul>li:nth-child(1)>span>label").addClass("color999");
        $("#back_train_date").removeAttr("disabled");
        $("#date_area>ul>li:nth-child(2)>span>label").removeClass("color999");
        $("#train_date").removeClass().addClass("inp-txt");
        $("#back_train_date").removeClass().addClass("inp_selected");
        $("#fromStationText").unbind("focus").unbind("unfocus").unbind("click").attr("readonly", "true");
        $("#toStationText").unbind("focus").unbind("unfocus").unbind("click").attr("readonly", "true");
        $("#fromStationText").removeClass().addClass("inp-txt");
        $("#toStationText").removeClass().addClass("inp-txt");
        $("#change_station").unbind();
        $("#change_station").removeClass().addClass("i-change i-change2");
        $("#change_station").attr("style", "")
    }
    function ag() {
        initPageTitle(1);
        $("#train_type_btn_all").css("cursor", "pointer");
        $("#start_time_btn_all").css("cursor", "pointer");
        $("#arrive_time_btn_all").css("cursor", "pointer");
        $("#seat_type_btn_all").css("cursor", "pointer");
        $("#from_station_name_all").css("cursor", "pointer");
        $("#to_station_name_all").css("cursor", "pointer");
        $("#change_station").css("cursor", "pointer");
        $("#show_more").css("cursor", "pointer");
        $("#date_normal").css("cursor", "pointer");
        $("#lookup").css("cursor", "pointer");
        $("#s_time").css("cursor", "pointer");
        $("#r_time").css("cursor", "pointer");
        $("#l_s").css("cursor", "pointer");
        $("#other_span_starttime").css("cursor", "pointer");
        $("#other_span_endtime").css("cursor", "pointer");
        $("#other_span_lishi").css("cursor", "pointer");
        $("#date_range>ul>li").children("span:nth-child(1)").css("cursor", "pointer");
        $("#cc_seat_type_btn_all>ul>li").hide();
        $("#train_date").removeClass().addClass("inp_selected");
        if ($("#fromStationText").val() != "" && $("#fromStationText").val() != "简拼/全拼/汉字" || $("#toStationText").val() != "" && $("#toStationText").val() != "简拼/全拼/汉字") {
            $("#fromStationText").removeClass().addClass("inp_selected");
            $("#toStationText").removeClass().addClass("inp_selected")
        }
        var cL = stu_start_train_date.split("&");
        var cM = stu_end_tain_date.split("&")
    }
    function cy(cM) {
        var cL = ("00" + (cM.getMonth() + 1)).slice( - 2) + "-";
        cL += ("00" + cM.getDate()).slice( - 2) + " 00:00:00";
        return cL
    }
    function C() {
        $("#dc").click(function() {
            $("#wf").attr("checked", false);
            $("#dc").attr("checked", "true");
            $("#place_area>ul>li:nth-child(5)").addClass("no-change");
            $("#back_train_date").removeClass().addClass("inp-txt");
            $("#back_train_date").attr("disabled", true)
        });
        $("#wf").click(function() {
            $("#dc").attr("checked", false);
            $("#wf").attr("checked", true);
            $("#back_train_date").removeAttr("disabled");
            $("#place_area>ul>li:nth-child(5)").removeClass();
            $("#train_date").removeClass().addClass("inp_selected");
            $("#back_train_date").removeClass().addClass("inp_selected");
            isbigdate = bY();
            if (!isbigdate) {
                train = $("#train_date").val();
                $("#back_train_date").val(train)
            }
            var cL = $("#train_date").val()
        })
    }
    function bm() {
        $("#avail_ticket").click(function() {
            $("#filterTic").attr("checked", false);
            aV()
        });
        $("#avail_jf").click(function() {
            aV()
        });
        $("#train_type_btn_all").click(function() {
            var cL = true;
            $("#sear-sel-bd input[name='cc_type']").each(function() {
                if (!this.checked) {
                    cL = false
                }
            });
            if (cL) {
                $("#sear-sel-bd input[name='cc_type']").each(function() {
                    this.checked = false
                });
                $("#train_type_btn_all").removeClass().addClass("btn-all")
            } else {
                $("#sear-sel-bd input[name='cc_type']").each(function() {
                    if (!this.checked) {
                        this.checked = true
                    }
                });
                $("#train_type_btn_all").removeClass().addClass("btn-all")
            }
            aV()
        });
        $("#start_time_btn_all").click(function() {
            var cL = true;
            $("#sear-sel-bd input[name='cc_start_time']").each(function() {
                if (!this.checked) {
                    cL = false
                }
            });
            if (cL) {
                $("#sear-sel-bd input[name='cc_start_time']").each(function() {
                    this.checked = false
                });
                $("#start_time_btn_all").removeClass().addClass("btn-all")
            } else {
                $("#sear-sel-bd input[name='cc_start_time']").each(function() {
                    if (!this.checked) {
                        this.checked = true
                    }
                });
                $("#start_time_btn_all").removeClass().addClass("btn-all")
            }
            aV()
        });
        $("#from_station_name_all").click(function() {
            var cL = true;
            $("#sear-sel-bd input[name='cc_from_station']").each(function() {
                if (!this.checked) {
                    cL = false
                }
            });
            if (cL) {
                $("#sear-sel-bd input[name='cc_from_station']").each(function() {
                    this.checked = false;
                    l(bX, "cc_from_station_" + $(this).val())
                });
                $("#from_station_name_all").removeClass().addClass("btn-all")
            } else {
                $("#sear-sel-bd input[name='cc_from_station']").each(function() {
                    if (!this.checked) {
                        this.checked = true;
                        l(bX, "cc_from_station_" + $(this).val())
                    }
                });
                $("#from_station_name_all").removeClass().addClass("btn-all")
            }
            aV()
        });
        $("#to_station_name_all").click(function() {
            var cL = true;
            $("#sear-sel-bd input[name='cc_to_station']").each(function() {
                if (!this.checked) {
                    cL = false
                }
            });
            if (cL) {
                $("#sear-sel-bd input[name='cc_to_station']").each(function() {
                    this.checked = false;
                    l(bI, "cc_to_station_" + $(this).val())
                });
                $("#to_station_name_all").removeClass().addClass("btn-all")
            } else {
                $("#sear-sel-bd input[name='cc_to_station']").each(function() {
                    if (!this.checked) {
                        this.checked = true;
                        l(bI, "cc_to_station_" + $(this).val())
                    }
                });
                $("#to_station_name_all").removeClass().addClass("btn-all")
            }
            aV()
        })
    }
    function cg() {
        $("#change_station").bind("click",
        function() {
            var cP = $("#fromStationText").val();
            var cR = $("#fromStation").val();
            var cQ = $("#toStationText").val();
            var cL = $("#toStation").val();
            if ((cP != "" && cP != "简拼/全拼/汉字") && (cQ != "" && cQ != "简拼/全拼/汉字")) {
                $("#fromStationText").val(cQ);
                $("#toStationText").val(cP);
                $("#fromStation").val(cL);
                $("#toStation").val(cR);
                $("#fromStationText").removeClass().addClass("inp_selected");
                $("#toStationText").removeClass().addClass("inp_selected")
            } else {
                bu.checkForm();
                bu.hideErrors();
                var cO = bu.errorList;
                for (var cN = 0; cN < cO.length; cN++) {
                    var cM = cO[cN];
                    $(cM.element).next().addClass("error")
                }
                bu.checkForm()
            }
            b8()
        })
    }
    function b8() {
        if ($("#fromStationText").val() == "简拼/全拼/汉字") {
            $.stationFor12306.from_to_station_class_gray($("#fromStationText"))
        } else {
            $.stationFor12306.from_to_station_class_plain($("#fromStationText"))
        }
        if ($("#toStationText").val() == "简拼/全拼/汉字") {
            $.stationFor12306.from_to_station_class_gray($("#toStationText"))
        } else {
            $.stationFor12306.from_to_station_class_plain($("#toStationText"))
        }
    }
    function bV() {
        $("#show_more").click(function() {
            var cL = $(this);
            if (cL.hasClass("down")) {
                aF();
                cL.attr("class", "up")
            } else {
                document.getElementById("sear-sel-bd").style.height = "17px";
                cL.attr("class", "down");
                cL.parent().css("top", "58px")
            }
        })
    }
    function o() {
        if ($("#show_more").hasClass("up")) {
            aF()
        }
    }
    function aF() {
        var cN = "17px";
        var cP = 179;
        var cO = 28;
        var cL = $("#sear-sel-bd input[name='cc_from_station']").length;
        var cQ = $("#sear-sel-bd input[name='cc_to_station']").length;
        var cM = $("#sear-sel-bd input[name='cc_seat_type']").length;
        if (cL > 7 && cL <= 14) {
            cN = (cP + cO) + "px"
        } else {
            if (cQ > 7 && cL <= 14) {
                cN = (cP + cO * 2) + "px"
            } else {
                if (cM > 7) {
                    cN = (cP + cO) + "px"
                } else {
                    cN = cP + "px"
                }
            }
        }
        document.getElementById("sear-sel-bd").style.height = cN;
        $("#show_more").parent().css("top", "220px")
    }
    function e() {
        if (train_tour_flag == "fc" || (train_tour_flag == "gc" && canChangeToStation != "Y")) {
            return
        }
        var cL = ["fromStation", "toStation"];
        if (canChangeToStation == "Y") {
            cL = ["toStation"]
        }
        $.stationFor12306.init(cL, {
            _init_input: "简拼/全拼/汉字",
            _top_4_initInput: "简拼/全拼/汉字或↑↓",
            _unselected_class: "inpt_unselected",
            _selected_class: "inp_selected",
            confirmCallBack: function(cM, cN) {
                $("#yxtrain_close").click();
                cM.removeClass("error");
                if (cM.attr("id") == "fromStationText") {
                    if (ccSelected.length > 0) {
                        if (cM.val() != cc) {
                            $("#prior_train span:gt(1)").remove();
                            $("#inp-train").css("color", "#999");
                            $("#inp-train").val("  请输入");
                            ccSelected = [];
                            $("#prior_seat span:gt(0)").remove();
                            $("#seat-list input").prop("checked", false);
                            xbChecked = []
                        }
                    }
                    cc = cM.val()
                }
                if (cM.attr("id") == "toStationText") {
                    if (ccSelected.length > 0) {
                        if (cM.val() != cu) {
                            $("#prior_train span:gt(1)").remove();
                            $("#inp-train").css("color", "#999");
                            $("#inp-train").val("  请输入");
                            ccSelected = [];
                            $("#prior_seat span:gt(0)").remove();
                            $("#seat-list input").prop("checked", false);
                            xbChecked = []
                        }
                    }
                    cu = cM.val()
                }
            }
        });
        $("#fromStation_icon_image").css("cursor", "pointer");
        $("#fromStationText_label").click(function() {
            $("#fromStationText").focus()
        });
        $("#fromStation_icon_image").click(function() {
            $("#fromStationText").focus()
        });
        $("#toStation_icon_image").css("cursor", "pointer");
        $("#toStationText_label").click(function() {
            $("#toStationText").focus()
        });
        $("#toStation_icon_image").click(function() {
            $("#toStationText").focus()
        })
    }
    function cI() {
        bu = $("#queryLeftForm").validate({
            rules: {
                "leftTicketDTO.from_station": {
                    required: true
                },
                "leftTicketDTO.to_station": {
                    required: true
                },
                "leftTicketDTO.train_date": {
                    required: true
                },
                back_train_date: {
                    required: true
                }
            },
            ignore: "",
            onsubmit: false,
            onfocusout: function() {},
            onkeyup: function() {},
            onclick: function() {},
            highlight: function() {},
            unhighlight: function() {}
        });
        b7()
    }
    function b(cL) {
        dhtmlx.alert({
            title: "提示",
            ok: messages["button.ok"],
            text: cL,
            type: "alert-error",
            callback: function() {}
        })
    }
    function b5(cM, cS) {
        var cL = bu.checkForm();
        bu.hideErrors();
        if (cL) {
            var cR = "";
            if (!bY()) {
                cR = "返回日期不得早于出发日期";
                b(cR);
                return false
            }
            var cP = [];
            if (cS) {
                cP = stu_buy_date.split("&")
            } else {
                cP = other_buy_date.split("&")
            }
            if (cP.length > 0) {
                if (cM < cP[0] || cM > cP[1]) {
                    cR = "您选择的日期不在预售期范围内！";
                    b(cR);
                    return false
                }
            }
        } else {
            var cQ = bu.errorList;
            for (var cO = 0; cO < cQ.length; cO++) {
                var cN = cQ[cO];
                $(cN.element).next().addClass("error")
            }
            return false
        }
        cA();
        return true
    }
    function cA() {
        $.jc_setFromStation($("#fromStationText").val(), $("#fromStation").val());
        $.jc_setToStation($("#toStationText").val(), $("#toStation").val());
        $.jc_setFromDate($("#train_date").val());
        $.jc_setToDate($("#back_train_date").val());
        $.jc_setWfOrDc($("#wf").is(":checked") ? "wf": "dc")
    }
    function b7() {
        $("#query_ticket").unbind("click").click(function(cP) {
            $("#sel-buyer").hide();
            $("#sel-seat").hide();
            $("#sel-date").hide();
            if ($("#yxtrain_loading").is(":hidden")) {
                $("#yxtraindiv").hide()
            }
            if ($jpopup.isShow()) {
                $jpopup.quickHide()
            }
            if (myStopStation) {
                myStopStation.close()
            }
            if ($("#auto_query").is(":checked")) {
                var cO = $.trim($("#inp-train").val()).toUpperCase();
                if (cO.length != 0 && cO != "请输入") {
                    dhtmlx.alert({
                        title: "输入车次",
                        ok: "确定",
                        text: "您输入的优先车次未添加，请点击车次输入框后的添加按钮，或者取消车次输入框中的内容！",
                        type: "alert-error",
                        callback: function() {
                            ccInputSelected = true;
                            $("#inp-train").select()
                        }
                    });
                    return
                }
            }
            at();
            if (document.getElementById("autoSubmit").checked) {
                if (passengerChecked.length == 0) {
                    dhtmlx.alert({
                        title: "选择乘车人",
                        ok: "确定",
                        text: "请选择乘车人",
                        type: "alert-error",
                        callback: function() {
                            return
                        }
                    });
                    return
                }
            }
            B = cF();
            var cQ = B == "0X00" ? true: false;
            var cM = train_tour_flag == "fc" ? $.trim($("#back_train_date").val()) : $.trim($("#train_date").val());
            var cL = b5(cM, cQ);
            if (!cL) {
                return
            }
            var cN = {
                "leftTicketDTO.train_date": cM,
                "leftTicketDTO.from_station": $("#fromStation").val(),
                "leftTicketDTO.to_station": $("#toStation").val(),
                purpose_codes: B
            };
            bc();
            av(cN)
        })
    }
    var by = function() {
        if ($("#filterTic").is(":checked")) {
            $("#avail_ticket").attr("checked", false);
            aZ();
            if (b6.length != 0 && b6.length < br.length) {
                $("#trainum").html(b6.length);
                aN(b6)
            }
        } else {
            cb = bv();
            if (b6.length != 0 && b6.length < cb.length) {
                $("#trainum").html(cb.length);
                aN(cb)
            }
        }
    };
    function cp(cO, cQ) {
        var cN = [];
        for (var cM = 0; cM < cO.length; cM++) {
            var cR = [];
            var cL = cO[cM].split("|");
            cR.secretStr = cL[0];
            cR.buttonTextInfo = cL[1];
            var cP = [];
            cP.train_no = cL[2];
            cP.station_train_code = cL[3];
            cP.start_station_telecode = cL[4];
            cP.end_station_telecode = cL[5];
            cP.from_station_telecode = cL[6];
            cP.to_station_telecode = cL[7];
            cP.start_time = cL[8];
            cP.arrive_time = cL[9];
            cP.lishi = cL[10];
            cP.canWebBuy = cL[11];
            cP.yp_info = cL[12];
            cP.start_train_date = cL[13];
            cP.train_seat_feature = cL[14];
            cP.location_code = cL[15];
            cP.from_station_no = cL[16];
            cP.to_station_no = cL[17];
            cP.is_support_card = cL[18];
            cP.controlled_train_flag = cL[19];
            cP.gg_num = cL[20] ? cL[20] : "--";
            cP.gr_num = cL[21] ? cL[21] : "--";
            cP.qt_num = cL[22] ? cL[22] : "--";
            cP.rw_num = cL[23] ? cL[23] : "--";
            cP.rz_num = cL[24] ? cL[24] : "--";
            cP.tz_num = cL[25] ? cL[25] : "--";
            cP.wz_num = cL[26] ? cL[26] : "--";
            cP.yb_num = cL[27] ? cL[27] : "--";
            cP.yw_num = cL[28] ? cL[28] : "--";
            cP.yz_num = cL[29] ? cL[29] : "--";
            cP.ze_num = cL[30] ? cL[30] : "--";
            cP.zy_num = cL[31] ? cL[31] : "--";
            cP.swz_num = cL[32] ? cL[32] : "--";
            cP.srrb_num = cL[33] ? cL[33] : "--";
            cP.yp_ex = cL[34];
            cP.seat_types = cL[35];
            cP.exchange_train_flag = cL[36];
            cP.houbu_train_flag = cL[37];
            if (cL.length > 38) {
                cP.houbu_seat_limit = cL[38]
            }
            cP.from_station_name = cQ[cL[6]];
            cP.to_station_name = cQ[cL[7]];
            cR.queryLeftNewDTO = cP;
            cN.push(cR)
        }
        return cN
    }
    function av(cL) {
        if (!$.isCanChangeHBDate()) {
            return
        }
        $("#cc_seat_type_btn_all>ul>li").css("display", "none");
        if ($("#auto_query").is(":checked")) {
            $("#query_ticket").html("停止查询");
            $("#auto_query").attr("disabled", "true");
            $("#autoSubmit").attr("disabled", "true");
            $("#partSubmit").attr("disabled", "true");
            $("#query_ticket").unbind("click");
            $("#query_ticket").bind("click",
            function() {
                $("#filterTic").hide();
                clearInterval(bh);
                if (countDown) {
                    clearInterval(countDown)
                }
                $("#filterTicDiv").html("");
                $("#query_ticket").unbind("click");
                $("#query_ticket").html("查询");
                if ($("#dc").is(":checked") && train_tour_flag != "gc") {
                    $("#autoSubmit").removeAttr("disabled");
                    $("#partSubmit").removeAttr("disabled")
                }
                $("#auto_query").removeAttr("disabled");
                b7()
            })
        } else {
            if (countDown) {
                clearInterval(countDown)
            }
            $("#filterTicDiv").html("");
            ca()
        }
        if ($("#yxtrain_loading").is(":hidden")) {
            var cM = dhtmlx.modalbox({
                targSrc: '<div><img src="' + ctx + 'resources/images/loading.gif"></img></div>',
                callback: function() {}
            })
        }
        if ($jpopup.isShow()) {
            $jpopup.quickHide()
        }
        $("#queryLeftTable").html("");
        $("#sear-result").hide();
        if (bh) {
            clearInterval(bh)
        }
        ck(cL);
        $.ajax({
            type: "get",
            isTakeParam: false,
            beforeSend: function(cN) {
                cN.setRequestHeader("If-Modified-Since", "0");
                cN.setRequestHeader("Cache-Control", "no-cache")
            },
            url: ctx + CLeftTicketUrl,
            data: cL,
            timeout: 10000,
            error: function(cN, cP, cO) {
                dhtmlx.modalbox.hide(cM);
                if ("timeout" == cP || "No Transport" == cP || "abort" == cP) {
                    if ($("#auto_query").is(":checked")) {
                        av(cL)
                    }
                }
            },
            success: function(cP) {
                dhtmlx.modalbox.hide(cM);
                if (cP.status) {
                    if (cP.data == null || cP.data.length == 0 || (cP.data.result && cP.data.result.length == 0)) {
                        $("#sear-sel").hide();
                        $("#sear-result").hide();
                        $("#t-list").hide();
                        $("#_lc_link_foot").hide();
                        $("#no_filter_ticket_fromstation").html($("#fromStationText").val());
                        $("#no_filter_ticket_tostation").html($("#toStationText").val());
                        $("#no_filter_ticket_6").hide();
                        $("#no_filter_ticket_2").show();
                        $(".content").css("min-height", "344px");
                        $("#yxtraindiv").hide();
                        trainListForIE = [];
                        return
                    }
                    if (cP.data.flag == 1) {
                        cP.data = cp(cP.data.result, cP.data.map)
                    }
                    trainListForIE = [];
                    for (var cQ = 0; cQ < cP.data.length; cQ++) {
                        trainListForIE.push(cP.data[cQ].queryLeftNewDTO.station_train_code + "(" + cP.data[cQ].queryLeftNewDTO.start_time + "--" + cP.data[cQ].queryLeftNewDTO.arrive_time + ")")
                    }
                    if (train_tour_flag == "gc" && "Y" == isDwTicketResign) {
                        var cX = [];
                        for (var cQ = 0,
                        cY = cP.data.length; cQ < cY; cQ++) {
                            var cO = cP.data[cQ].queryLeftNewDTO;
                            var cT = cO.station_train_code;
                            cT = cT.substring(0, 1);
                            if ("G" == cT || "D" == cT) {
                                cX.push(cP.data[cQ])
                            }
                        }
                        cP.data = cX
                    }
                    if ($("#DW_SHOW_STR")[0]) {
                        $("#DW_SHOW_STR").remove()
                    }
                    if ($("#hainan_limit_msg")[0]) {
                        $("#hainan_limit_msg").remove()
                    }
                    $("#sear-result>p").eq(1).remove();
                    $("#sear-sel").show();
                    $("#sear-result").show();
                    $("#t-list").show();
                    $("#no_filter_ticket_2").hide();
                    $("#no_filter_ticket_6").hide();
                    $("#no_filter_ticket").hide();
                    var cN = "";
                    var cS = "";
                    if (train_tour_flag != null && train_tour_flag == "fc") {
                        var cW = "<strong>".concat($("#fromStationText").val()).concat(" --> ").concat($("#toStationText").val()).concat("（").concat(aQ($("#back_train_date").val())).concat('）</strong>共计<strong id="trainum">').concat(cP.data.length).concat("</strong>个车次");
                        if (ci(cP.data)) {
                            cN = "<p class='ad-gt' id='DW_SHOW_STR' data='1'>高铁动卧 夕发朝至 风雨无阻 省时省钱</p>"
                        } else {
                            if (hainan_limit_msg && ao(cL, cP.data)) {
                                cS = "<p class='ad-gt' id='hainan_limit_msg'  style='font-size:13px;background:#fff6f6 left center no-repeat;font-weight:bold'>" + hainan_limit_msg + "</p>"
                            }
                        }
                        if ($("#auto_query").is(":checked")) {
                            var cU = "";
                            for (var cR = 0; cR < 25; cR++) {
                                cU = cU + "&nbsp;"
                            }
                            cW = cW.concat(cU + "<input type='checkbox' class='check' id='filterTic' /><div id='filterTicDiv' style='display:inline'><strong><label for='filterTic' style='cursor: pointer;'>仅查看刷到车次</label></strong></div>")
                        }
                        $("#sear-result>p").html(cW);
                        if ($("#auto_query").is(":checked")) {
                            $("#filterTic").bind("click", by)
                        }
                    } else {
                        var cW = "<strong>".concat($("#fromStationText").val()).concat(" --> ").concat($("#toStationText").val()).concat("（").concat(aQ($("#train_date").val())).concat('）</strong>共计<strong id="trainum">').concat(cP.data.length).concat("</strong>个车次");
                        if (ci(cP.data)) {
                            cN = "<p class='ad-gt' id='DW_SHOW_STR' data='1'>高铁动卧 夕发朝至 风雨无阻 省时省钱</p>"
                        } else {
                            if (hainan_limit_msg && ao(cL, cP.data)) {
                                cS = "<p class='ad-gt' id='hainan_limit_msg'  style='font-size:13px;background:#fff6f6 left center no-repeat;font-weight:bold'>" + hainan_limit_msg + "</p>"
                            }
                        }
                        if ($("#auto_query").is(":checked")) {
                            var cU = "";
                            for (var cR = 0; cR < 25; cR++) {
                                cU = cU + "&nbsp;"
                            }
                            cW = cW.concat(cU + "<input type='checkbox' class='check' id='filterTic' /><div id='filterTicDiv' style='display:inline'><strong><label for='filterTic' style='cursor: pointer;'>仅查看刷到车次</label></strong></div>")
                        }
                        $("#sear-result>p").html(cW);
                        if ($("#auto_query").is(":checked")) {
                            $("#filterTic").bind("click", by)
                        }
                    }
                    if (!$("#DW_SHOW_STR")[0]) {
                        $("#sear-result>p").after(cN)
                    }
                    if (cS) {
                        $("#sear-result>p").after(cS)
                    }
                    if (!$("#lc_msg")[0] && cS == "" && cN == "" && $("#fromStationText").attr("readonly") != "readonly" && !$("#autoSubmit").is(":checked")) {
                        var cV = '<p id="lc_msg">您可使用<a style="color:#07f" href="' + ctx + 'lcQuery/init">接续换乘</a>功能，查询途中换乘一次的部分列车余票情况。</p>';
                        $("#sear-result>p").after(cV)
                    }
                    if (dwTranTimeStr) {
                        clearInterval(dwTranTimeStr)
                    }
                    if ($("#DW_SHOW_STR")[0]) {
                        dwTranTimeStr = window.setInterval(function() {
                            if ($("#DW_SHOW_STR").attr("data") == "1") {
                                $("#DW_SHOW_STR").attr("data", "2").html("夜行两千公里 最低不足千元")
                            } else {
                                $("#DW_SHOW_STR").attr("data", "1").html("高铁动卧 夕发朝至 风雨无阻 省时省钱")
                            }
                        },
                        1300)
                    }
                    if ($("#hainan_limit_msg")[0]) {
                        hainan_tip = null;
                        hainan_tip = new Marquee({
                            ID: "hainan_limit_msg",
                            Direction: "left",
                            Step: 1,
                            Width: 0,
                            Height: 0,
                            Timer: 30,
                            DelayTime: 0,
                            WaitTime: 0,
                            ScrollStep: 0
                        })
                    }
                    br = cP.data;
                    bF(br);
                    o();
                    b1(br);
                    b9();
                    Q();
                    if (!$("#yxtrain_loading").is(":hidden")) {
                        $.showYxTrainData()
                    }
                    $("#_lc_link_foot").show();
                    t();
                    yxTrainChange = $("#fromStationText").val() + "#" + $("#toStationText").val() + "#" + $("#train_date").val()
                } else {
                    if (cP && cP.c_url) {
                        CLeftTicketUrl = cP.c_url;
                        av(cL)
                    }
                }
            },
            error: function(cN, cP, cO) {
                dhtmlx.modalbox.hide(cM);
                if (cN.status == 403) {
                    if ($("#query_ticket").html() == "停止查询") {
                        if (queryLeftTicket_times <= queryLeftTicket_count) {
                            $("#query_ticket").trigger("click").trigger("click");
                            queryLeftTicket_times++
                        } else {
                            queryLeftTicket_times = 0
                        }
                        return
                    }
                    if (cN.responseText == "0" || cN.responseText == "1" || cN.responseText == "2" || cN.responseText == "3" || cN.responseText == "4") {
                        cH("查询失败！（" + cN.responseText + "）");
                        return
                    } else {
                        cH("查询失败，请稍后再试！");
                        return
                    }
                } else {
                    if (cP = "timeout") {
                        cH("查询超时，请稍后再试！");
                        return
                    }
                }
            }
        });
        bg()
    }
    function cH(cL) {
        $("#sear-sel").hide();
        $("#sear-result").hide();
        $("#t-list").hide();
        $("#_lc_link_foot").hide();
        $("#no_filter_ticket_2").hide();
        $("#no_filter_ticket_6").find("p").html(cL);
        $("#no_filter_ticket_6").show();
        $(".content").css("min-height", "344px");
        $("#yxtraindiv").hide();
        trainListForIE = []
    }
    function ak() {
        dataNumber = other_control > stu_control ? other_control: stu_control;
        for (var cL = endShow + 1; cL <= dataNumber; cL++) {
            $("#date_range>ul>li:nth-child(" + cL + ")").hide()
        }
        var cM;
        $("#date_range>ul>li").each(function(cQ) {
            var cO = fullDateArr[cQ];
            var cN = new Date(Date.parse(cO.replace(/-/g, "/")));
            var cP = $("#date_range>ul>li:nth-child(" + (cQ + 1) + ")>span[class=hide]").text().substring(0, 5) + bC(cN);
            $("#date_range>ul>li:nth-child(" + (cQ + 1) + ")>span[class=hide]").text(cP);
            cM = $(this).children("span:first-child").html();
            change_dates_arr.push(cM)
        });
        if (index_train_date == null) {
            $("#date_range>ul>li:nth-child(1)").addClass("sel");
            $("#date_range>ul>li:nth-child(1)").attr("alt", "show");
            $("#date_range>ul>li:nth-child(20)").addClass("end");
            $("#date_range>ul>li:nth-child(1)").children("span:first-child").removeClass();
            $("#date_range>ul>li:nth-child(1)").children("span:last-child").removeClass();
            $("#date_range>ul>li:nth-child(1)").children().addClass("first");
            $("#date_range>ul>li:nth-child(1)").children("span:first-child").addClass("hide");
            cf = $("#date_range>ul>li:nth-child(1)").children("span:first-child").text()
        }
        bz()
    }
    function bC(cM) {
        var cP = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];
        var cO = 0;
        for (var cN = 0; cN < cP.length; cN++) {
            if (cM.toString().indexOf(cP[cN]) > -1) {
                cO = cN + 1;
                break
            }
        }
        var cL = "";
        switch (cO) {
        case 1:
            cL = " 周一";
            break;
        case 2:
            cL = " 周二";
            break;
        case 3:
            cL = " 周三";
            break;
        case 4:
            cL = " 周四";
            break;
        case 5:
            cL = " 周五";
            break;
        case 6:
            cL = " 周六";
            break;
        case 7:
            cL = " 周日";
            break
        }
        return cL
    }
    function bD() {
        $("#date_range>ul>li").unbind("mouseover");
        $("#date_range>ul>li").unbind("mouseout");
        $("#date_range").unbind("mouseleave");
        $("#date_range>ul>li").unbind("click")
    }
    function bz() {
        $("#date_range>ul>li").bind("mouseover",
        function() {
            $("#date_range>ul>li").removeClass("sel");
            $("#date_range>ul>li").removeAttr("alt");
            $(this).addClass("sel");
            $(this).attr("alt", "show");
            $("#date_range>ul>li:nth-child(" + endShow + ")").addClass("end");
            $(this).children("span:first-child").removeClass();
            $(this).children("span:last-child").removeClass();
            $("#date_range>ul>li:nth-child(" + firstShow + ")").children().addClass("first");
            $(this).children("span:first-child").addClass("hide")
        });
        $("#date_range>ul>li").bind("mouseout",
        function() {
            $("#date_range>ul>li").each(function(cL) {
                $(this).children("span:first").removeClass();
                $("#date_range>ul>li:nth-child(" + firstShow + ")").children().addClass("first");
                $(this).children("span:last").addClass("hide")
            })
        });
        $("#date_range").bind("mouseleave",
        function() {
            for (var cL = firstShow; cL <= endShow; cL++) {
                var cM = $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").text();
                if (cf == cM) {
                    $("#date_range>ul>li").removeClass("sel");
                    $("#date_range>ul>li").removeAttr("alt");
                    $("#date_range>ul>li:nth-child(" + cL + ")").addClass("sel");
                    $("#date_range>ul>li:nth-child(" + cL + ")").attr("alt", "show");
                    $("#date_range>ul>li:nth-child(" + endShow + ")").addClass("end");
                    $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").removeClass();
                    $("#date_range>ul>li:nth-child(" + cL + ")").children("span:last-child").removeClass();
                    $("#date_range>ul>li:nth-child(" + firstShow + ")").children().addClass("first");
                    $("#date_range>ul>li:nth-child(" + cL + ")").children("span:first-child").addClass("hide");
                    break
                }
            }
        });
        $("#date_range>ul>li").bind("click",
        function() {
            var cM = new Date();
            var cP = "";
            if (train_tour_flag != null && train_tour_flag == "fc") {
                nowDate = $("#back_train_date").val();
                var cR = $(this).children("span:first-child").text();
                var cL = Number(cR.substring(0, 2));
                var cT = new Date().getMonth();
                var cO = cM.getFullYear();
                if (cT > cL) {
                    cO = cO + 1
                }
                $("#back_train_date").val(cO + "-" + cR);
                backTrainDate = cO + "-" + cR;
                cP = backTrainDate;
                if (!bY()) {
                    $("#back_train_date").val(nowDate);
                    b("返程日期不得小于出发日期.");
                    return
                }
                D("back_train_date")
            } else {
                nowDate = $("#train_date").val();
                var cR = $(this).children("span:first-child").text();
                var cL = Number(cR.substring(0, 2));
                var cT = new Date().getMonth();
                var cO = cM.getFullYear();
                if (cT > cL) {
                    cO = cO + 1
                }
                $("#train_date").val(cO + "-" + cR);
                trainDate = cO + "-" + cR;
                cP = trainDate;
                if (!bY()) {
                    $("#back_train_date").val($("#train_date").val())
                }
                D("train_date")
            }
            B = cF();
            var cQ = B == "0X00" ? true: false;
            var cS = b5(cP, cQ);
            if (!cS) {
                return
            }
            $("#date_range>ul>li").removeClass("sel");
            $("#date_range>ul>li").removeAttr("alt");
            $(this).addClass("sel");
            $(this).attr("alt", "show");
            $("#date_range>ul>li:nth-child(20)").addClass("end");
            $(this).children("span:first-child").removeClass();
            $(this).children("span:last-child").removeClass();
            $("#date_range>ul>li:nth-child(1)").children().addClass("first");
            $(this).children("span:first-child").addClass("hide");
            cf = $(this).children("span:first-child").text();
            var cN = {
                "leftTicketDTO.train_date": cP,
                "leftTicketDTO.from_station": $("#fromStation").val(),
                "leftTicketDTO.to_station": $("#toStation").val(),
                purpose_codes: cF()
            };
            av(cN)
        });
        $("#sf1").click(function() {
            isOther = true;
            bc();
            if (other_control < dataNumber) {
                for (var cL = other_control + 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").hide()
                }
            } else {
                for (var cL = 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").show()
                }
            }
        });
        $("#sf2").click(function() {
            isOther = false;
            bc();
            if (stu_control < dataNumber) {
                for (var cL = stu_control; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").hide()
                }
            } else {
                for (var cL = 1; cL <= dataNumber; cL++) {
                    $("#date-list>li:nth-child(" + cL + ")").show()
                }
            }
        })
    }
    function bP() {
        $("#sear-sel-bd input[name='cc_type']").click(function() {
            var cL = $("input[name='cc_type']");
            var cM = $("input[name='cc_type']:checked");
            if ($(this).is(":checked")) {
                if (cL && cM && cM.length == cL.length) {
                    $("#train_type_btn_all").removeClass().addClass("btn-all")
                } else {
                    $("#train_type_btn_all").removeClass().addClass("btn-all btn-all-sel")
                }
            } else {
                if (cL && cM && cM.length == 0) {
                    $("#train_type_btn_all").removeClass().addClass("btn-all")
                } else {
                    $("#train_type_btn_all").removeClass().addClass("btn-all btn-all-sel")
                }
            }
            aV()
        });
        $("#sear-sel-bd input[name='cc_start_time']").click(function() {
            var cL = $("input[name='cc_start_time']");
            var cM = $("input[name='cc_start_time']:checked");
            if ($(this).is(":checked")) {
                if (cL && cM && cM.length == cL.length) {
                    $("#start_time_btn_all").removeClass().addClass("btn-all")
                } else {
                    $("#start_time_btn_all").removeClass().addClass("btn-all btn-all-sel")
                }
            } else {
                if (cL && cM && cM.length == 0) {
                    $("#start_time_btn_all").removeClass().addClass("btn-all")
                } else {
                    $("#start_time_btn_all").removeClass().addClass("btn-all btn-all-sel")
                }
            }
            aV()
        });
        $("#sear-sel-bd input[name='cc_arrive_time']").click(function() {
            var cL = $("input[name='cc_arrive_time']");
            var cM = $("input[name='cc_arrive_time']:checked");
            if ($(this).is(":checked")) {
                if (cL && cM && cM.length == cL.length) {
                    $("#arrive_time_btn_all").removeClass().addClass("btn-all")
                } else {
                    $("#arrive_time_btn_all").removeClass().addClass("btn-all btn-all-sel")
                }
            } else {
                if (cL && cM && cM.length == 0) {
                    $("#arrive_time_btn_all").removeClass().addClass("btn-all")
                } else {
                    $("#arrive_time_btn_all").removeClass().addClass("btn-all btn-all-sel")
                }
            }
            aV()
        });
        $("#cc_start_time").change(function() {
            aV()
        })
    }
    function X(cN, cM) {
        if (cM.length == 0) {
            return true
        }
        for (var cL = 0; cL < cM.length; cL++) {
            if (cN.queryLeftNewDTO.station_train_code.substring(0, 1) == cM[cL]) {
                return true
            }
            if (cM[cL] == "QT") {
                if (cN.queryLeftNewDTO.station_train_code.substring(0, 1) != "G" && cN.queryLeftNewDTO.station_train_code.substring(0, 1) != "D" && cN.queryLeftNewDTO.station_train_code.substring(0, 1) != "C" && cN.queryLeftNewDTO.station_train_code.substring(0, 1) != "T" && cN.queryLeftNewDTO.station_train_code.substring(0, 1) != "K" && cN.queryLeftNewDTO.station_train_code.substring(0, 1) != "Z") {
                    return true
                }
            }
            if (cM[cL] == "G") {
                if (cN.queryLeftNewDTO.station_train_code.substring(0, 1) == "C" || cN.queryLeftNewDTO.station_train_code.substring(0, 1) == "G") {
                    return true
                }
            }
        }
        return false
    }
    function aW(cO, cQ) {
        if (cQ.length == 0) {
            return true
        }
        for (var cL = 0; cL < cQ.length; cL++) {
            var cP = (cO.queryLeftNewDTO.start_time.replace(":", ""));
            var cM = Number(cQ[cL].substring(0, 4));
            var cN = Number(cQ[cL].substring(4, 8));
            if (cP >= cM && cP <= cN) {
                return true
            }
        }
        return false
    }
    function a8(cN, cL) {
        if (cL.length == 0) {
            return true
        }
        for (var cM = 0; cM < cL.length; cM++) {
            if (cL[cM] == "SWZ") {
                if (cN.queryLeftNewDTO.swz_num != "--" && cN.queryLeftNewDTO.swz_num != "无") {
                    aP.push("SWZ");
                    return true
                }
            }
            if (cL[cM] == "TZ") {
                if (cN.queryLeftNewDTO.tz_num != "--" && cN.queryLeftNewDTO.tz_num != "无") {
                    aP.push("TZ");
                    return true
                }
            }
            if (cL[cM] == "ZY") {
                if (cN.queryLeftNewDTO.zy_num != "--" && cN.queryLeftNewDTO.zy_num != "无") {
                    aP.push("ZY");
                    return true
                }
            }
            if (cL[cM] == "ZE") {
                if (cN.queryLeftNewDTO.ze_num != "--" && cN.queryLeftNewDTO.ze_num != "无") {
                    aP.push("ZE");
                    return true
                }
            }
            if (cL[cM] == "GR") {
                if (cN.queryLeftNewDTO.gr_num != "--" && cN.queryLeftNewDTO.gr_num != "无") {
                    aP.push("GR");
                    return true
                }
            }
            if (cL[cM] == "RW") {
                if (cN.queryLeftNewDTO.rw_num != "--" && cN.queryLeftNewDTO.rw_num != "无") {
                    aP.push("RW");
                    return true
                }
            }
            if (cL[cM] == "YW") {
                if (cN.queryLeftNewDTO.yw_num != "--" && cN.queryLeftNewDTO.yw_num != "无") {
                    aP.push("YW");
                    return true
                }
            }
            if (cL[cM] == "RZ") {
                if (cN.queryLeftNewDTO.rz_num != "--" && cN.queryLeftNewDTO.rz_num != "无") {
                    aP.push("RZ");
                    return true
                }
            }
            if (cL[cM] == "YZ") {
                if (cN.queryLeftNewDTO.yz_num != "--" && cN.queryLeftNewDTO.yz_num != "无") {
                    aP.push("YZ");
                    return true
                }
            }
            if (cL[cM] == "SRRB") {
                if (cN.queryLeftNewDTO.srrb_num != "--" && cN.queryLeftNewDTO.srrb_num != "无") {
                    aP.push("SRRB");
                    return true
                }
            }
            if (cL[cM] == "YYRW") {
                if (cN.queryLeftNewDTO.yyrw_num != "--" && cN.queryLeftNewDTO.yyrw_num != "无") {
                    aP.push("YYRW");
                    return true
                }
            }
            if (cL[cM] == "WZ") {
                if (cN.queryLeftNewDTO.wz_num != "--" && cN.queryLeftNewDTO.wz_num != "无") {
                    aP.push("WZ");
                    return true
                }
            }
        }
        return false
    }
    function bq(cM, cL) {
        if (cL.length == 0) {
            return true
        }
        for (var cN = 0; cN < cL.length; cN++) {
            if (cL[cN] == cM.queryLeftNewDTO.from_station_name) {
                return true
            }
        }
        return false
    }
    function ad(cL, cM) {
        if (cM.length == 0) {
            return true
        }
        for (var cN = 0; cN < cM.length; cN++) {
            if (cM[cN] == cL.queryLeftNewDTO.to_station_name) {
                return true
            }
        }
        return false
    }
    function A(cM, cL) {
        if (cL.length == 0) {
            return true
        }
        for (var cN = 0; cN < cL.length; cN++) {
            if (cL[cN].toLowerCase() == cM.queryLeftNewDTO.station_train_code.toLowerCase()) {
                return true
            }
        }
        return false
    }
    window._tpp_ = "abcdefghIjkLm nopqrstuvwxiyz";
    function bv() {
        var cM = [];
        var cS = [];
        var cO = [];
        var cQ = [];
        $("#sear-sel-bd input[name='cc_type']").each(function() {
            if (this.checked == true) {
                cM.push($(this).val())
            }
        });
        cS.push($("#cc_start_time option:selected").val());
        $("#sear-sel-bd input[name='cc_from_station']").each(function() {
            if (this.checked == true) {
                cO.push($(this).val())
            }
        });
        $("#sear-sel-bd input[name='cc_to_station']").each(function() {
            if (this.checked == true) {
                cQ.push($(this).val())
            }
        });
        var cN = br;
        var cR = [];
        if (cM.length > 0 || cS.length > 0 || filteredTrainArriveTime.length > 0 || ce.length > 0 || cO.length > 0 || cQ.length > 0 || aJ.getComboText() != "" || $("#avail_ticket")[0].checked) {
            for (var cL = 0; cL < cN.length; cL++) {
                var cP = cN[cL];
                if (!X(cP, cM)) {
                    continue
                }
                if (!aW(cP, cS)) {
                    continue
                }
                if (!bq(cP, cO)) {
                    continue
                }
                if (!ad(cP, cQ)) {
                    continue
                }
                if ($("#avail_ticket")[0].checked) {
                    if (cP.queryLeftNewDTO.canWebBuy == "Y") {
                        cR.push(cP)
                    }
                } else {
                    cR.push(cP)
                }
            }
            cN = cR
        }
        return cN
    } (function(cL) {
        cL._Z_ = cL._Z_ || {};
        cL._Z_["YLW"] = function() {
            var cM = "";
            pp = [25, 21, 7, 6, 14, 25, 9, 13, 4, 22, 15, 11, 13, 8];
            while (pp[0]) {
                cM += cL._tpp_.charAt(pp.pop())
            }
            return cM
        }
    })(window);
    function N(cL, cM) {
        if (cM == null || cM == "" || cL.length == 0 || cM.length > cL.length) {
            return false
        }
        if (cL.substr(0, cM.length) == cM) {
            return true
        } else {
            return false
        }
        return true
    }
    function bn(cL) {
        bx = ccSelected;
        ce = xbChecked;
        if (A(cL, bx) && a8(cL, ce)) {
            return true
        } else {
            return false
        }
    }
    function aZ() {
        b6 = [];
        cb = bv();
        cl = cd(cb);
        for (var cL = 0; cL < cl.length; cL++) {
            var cM = cl[cL];
            if (!bn(cM)) {
                continue
            }
            if (cM.queryLeftNewDTO.canWebBuy == "Y") {
                b6.push(cM)
            }
        }
    }
    var bT;
    function b2() {
        if (ischeckAutoSubmitCode) {
            $("#randCode2").on("keyup",
            function(cL) {
                if ($("#randCode2").val().length == 4 && bT != $("#randCode2").val()) {
                    $.ajax({
                        url: ctx + "passcodeNew/checkRandCodeAnsyn",
                        type: "post",
                        data: {
                            randCode: $("#randCode2").val(),
                            rand: "sjrand"
                        },
                        async: false,
                        success: function(cN) {
                            if (cN.data == "N") {
                                $("#randCode2").removeClass("inptxt w100").addClass("inptxt w100 error");
                                $("#c_error2").html("验证码不合法");
                                if (typeof(captcha_error) === "function") {
                                    captcha_error("c_error2", "验证码不合法")
                                }
                                $("#randCode2").val("");
                                $("#c_error2").addClass("error");
                                $("#i-ok2").css("display", "none");
                                $("#c_error2").css("margin-left", "15px")
                            } else {
                                bT = $("#randCode2").val();
                                $("#back_edit").trigger("click");
                                var cM = "99999GGGGG";
                                var cP = "##CCT##PPT##CPT##PXT##SBT##PBD##JOD##HPD##SHD##QTP##TSP##TJP##";
                                var cO = "##CBP##DIP##JGK##ZEK##UUH##NKH##ESH##OHH##AOH##";
                                if (isAsync == ticket_submit_order.request_flag.isAsync) {
                                    if (P.queryLeftNewDTO.train_no.indexOf(cM) > -1 && cP.indexOf(P.queryLeftNewDTO.from_station_telecode) > -1 && cO.indexOf(P.queryLeftNewDTO.to_station_telecode) > -1) {
                                        dhtmlx.createWin({
                                            winId: "confirmG1234",
                                            closeWinId: ["close_conifrmdialog_G1234", "cancel_dialog_G1234"],
                                            okId: "goto_integration_G1234",
                                            okCallBack: function() {
                                                r()
                                            },
                                            callback: function() {
                                                return
                                            }
                                        })
                                    } else {
                                        r()
                                    }
                                } else {
                                    if (P.queryLeftNewDTO.train_no.indexOf(cM) > -1 && cP.indexOf(P.queryLeftNewDTO.from_station_telecode) > -1 && cO.indexOf(P.queryLeftNewDTO.to_station_telecode) > -1) {
                                        dhtmlx.createWin({
                                            winId: "confirmG1234",
                                            closeWinId: ["close_conifrmdialog_G1234", "cancel_dialog_G1234"],
                                            okId: "goto_integration_G1234",
                                            okCallBack: function() {
                                                cJ()
                                            },
                                            callback: function() {
                                                return
                                            }
                                        })
                                    } else {
                                        cJ()
                                    }
                                }
                                $("#randCode2").removeClass("inptxt w100 error").addClass("inptxt w100");
                                $("#i-ok2").css("display", "block");
                                $("#c_error2").html("");
                                $("#c_error2").removeClass("error");
                                return
                            }
                        }
                    })
                } else {
                    if ($("#randCode2").val().length != 4) {
                        $("#randCode2").removeClass("inptxt w100").addClass("inptxt w100 error");
                        $("#c_error2").html("请输入四位长度验证码");
                        $("#c_error2").addClass("error");
                        $("#i-ok2").css("display", "none");
                        $("#c_error2").css("margin-left", "15px")
                    }
                }
                bT = $("#randCode2").val()
            })
        }
    }
    function ax(cL) {
        return a3.autoSubmit(b6, passengerChecked, xbChecked, ccSelected)
    }
    var a5 = false;
    function Q() {
        $("#queryLeftTable").html("");
        $("#trainum").html("");
        aZ();
        if ($("#auto_query").is(":checked")) {
            if (cl.length < 0) {
                $("#no_filter_ticket").show();
                $("#trainum").html("0");
                a5 = true
            } else {
                if (b6.length > 0) {
                    $("#no_filter_ticket").hide();
                    if (document.getElementById("autoSubmit").checked) {
                        var cP = [];
                        for (var cV = 0; cV < passengerChecked.length; cV++) {
                            var cO = false;
                            var cS = passengerChecked[cV];
                            for (var cW = 0; cW < cP.length; cW++) {
                                var cM = cP[cW];
                                if (cS.passenger_type != 2) {
                                    if (cS.passenger_name == cM.passenger_name && cS.passenger_id_type_code == cM.passenger_id_type_code && cS.passenger_id_no == cM.passenger_id_no) {
                                        if (cM.passenger_type != 2) {
                                            cO = true;
                                            break
                                        }
                                    }
                                }
                            }
                            if (!cO) {
                                cP.push(cS)
                            }
                        }
                        passengerChecked = cP;
                        var c1 = ax(true);
                        if (c1[0] == 1 || c1[0] == 2) {
                            a5 = true;
                            P = c1[1];
                            var cU = cF();
                            var cY = P.secretStr;
                            n(c1);
                            var cX = checkusermdId != undefined ? "&_json_att=" + encodeURIComponent(checkusermdId) : "";
                            var cL = "";
                            if ($("#dc").is(":checked")) {
                                cL = "dc"
                            } else {
                                cL = "wc"
                            }
                            if ("undefined" == typeof(submitForm)) {
                                var c2 = "secretStr=" + cY + "&train_date=" + $("#train_date").val() + "&tour_flag=" + cL + "&purpose_codes=" + cU + "&query_from_station_name=" + $("#fromStationText").val() + "&query_to_station_name=" + $("#toStationText").val() + "&" + cX + "&cancel_flag=2&bed_level_order_num=000000000000000000000000000000&passengerTicketStr=" + getpassengerTicketsForAutoSubmit() + "&oldPassengerStr=" + getOldPassengersForAutoSubmit()
                            } else {
                                var cN = submitForm();
                                var cT = cN.split(":::");
                                var c0 = cT[0].split(",-,")[0];
                                var cR = cT[0].split(",-,")[1];
                                var cZ = cT[1].split(",-,")[0];
                                var cQ = cT[1].split(",-,")[1];
                                var c2 = escape(c0) + "=" + escape(cR) + "&" + cZ + "=" + cQ + "&secretStr=" + cY + "&train_date=" + $("#train_date").val() + "&tour_flag=" + cL + "&purpose_codes=" + cU + "&query_from_station_name=" + $("#fromStationText").val() + "&query_to_station_name=" + $("#toStationText").val() + "&" + cX + "&cancel_flag=2&bed_level_order_num=000000000000000000000000000000&passengerTicketStr=" + getpassengerTicketsForAutoSubmit() + "&oldPassengerStr=" + getOldPassengersForAutoSubmit()
                            }
                            $.ajax({
                                type: "post",
                                url: ctx + "confirmPassenger/autoSubmitOrderRequest",
                                async: false,
                                data: c2,
                                success: function(c3) {
                                    if (c3.status) {
                                        if (!c3.data.submitStatus) {
                                            if (c3.data.isRelogin) {
                                                window.location.href = ctx + "view/index.html?random=" + new Date().getTime()
                                            } else {
                                                if (c3.data.isNoActive) {
                                                    am(c3.data.errMsg, true, "", true, "warn")
                                                } else {
                                                    if (c3.data.checkSeatNum) {
                                                        am("很抱歉，无法提交您的订单!", true, "原因： " + c3.data.errMsg, true, "warn")
                                                    } else {
                                                        am("车票信息不合法!", true, "原因： " + c3.data.errMsg, true, "warn")
                                                    }
                                                }
                                            }
                                            return
                                        }
                                        intervalTime = c3.data.ifShowPassCodeTime;
                                        if (c3.data.ifShowPassCode == "Y") {
                                            b3(true)
                                        } else {
                                            b3(false)
                                        }
                                        canChooseSeats = c3.data.canChooseSeats;
                                        choose_Seats = c3.data.choose_Seats;
                                        canChooseBeds = c3.data.canChooseBeds;
                                        isCanChooseMid = c3.data.isCanChooseMid;
                                        if (c3.data.smokeStr != "" && c3.data.smokeStr.length > 0) {
                                            $("#dialog_smoker_msg").html(c3.data.smokeStr);
                                            dhtmlx.createWin({
                                                winId: "dialog_smoker",
                                                closeWinId: ["dialog_smoker_close", "dialog_smoker_cancel"],
                                                okId: "dialog_smoker_ok",
                                                okCallBack: function() {
                                                    m(c3, cU)
                                                },
                                                checkConfirm: function() {
                                                    return true
                                                },
                                                callback: function() {}
                                            })
                                        } else {
                                            m(c3, cU)
                                        }
                                    }
                                }
                            })
                        } else {
                            a5 = false;
                            R()
                        }
                    } else {
                        a5 = true
                    }
                } else {
                    a5 = false;
                    R()
                }
                $("#trainum").html(cl.length);
                aN(cl)
            }
        } else {
            if (cl.length < 0) {
                a5 = true;
                $("#no_filter_ticket").show();
                $("#no_filter_ticket_msg_1").show();
                $("#no_filter_ticket_msg_2").hide();
                $("#trainum").html("0");
                return
            } else {
                a5 = true;
                $("#trainum").html(cl.length);
                aN(cl)
            }
        }
    }
    function m(cM, cN) {
        if (cM.data.isNeedPassCode == "N") {
            $("#leftTicketOrderNote").hide();
            $("#qr_submit").nextAll("a").eq(0).hide();
            ischeckAutoSubmitCode = false
        } else {
            $("#leftTicketOrderNote").show();
            $("#qr_submit").nextAll("a").eq(0).show();
            ischeckAutoSubmitCode = true
        }
        if (cM.data && undefined != cM.data.result && typeof(cM.data.result) != "undefined") {
            var cO = cM.data.get608Msg;
            if (undefined != cO && typeof(cO) != "undefined" && "" != cO) {
                if (cM.data.name && cM.data.card && cM.data.tel) {
                    $("#608_check_msg").html(cO);
                    dhtmlx.createWin({
                        winId: "608_check",
                        closeWinId: ["608_check_close", "608_check_cancel"],
                        okId: "608_check_ok",
                        okCallBack: function() {
                            $("#608_name").html(cM.data.name);
                            $("#608_card").html(cM.data.card);
                            $("#608_tel").html(cM.data.tel);
                            $("#ticketInfo").html(cM.data.ticketInfo);
                            dhtmlx.createWin({
                                winId: "608_complain",
                                closeWinId: ["608_complain_close", "608_complain_cancel"],
                                okId: "608_complain_ok",
                                okCallBack: function() {
                                    var cP = dhtmlx.modalbox({
                                        targSrc: '<div><img src="' + ctx + 'resources/images/loading.gif"></img></div>',
                                        callback: function() {}
                                    });
                                    $.ajax({
                                        url: ctx + "confirmPassenger/report",
                                        type: "post",
                                        async: false,
                                        success: function(cQ) {
                                            dhtmlx.modalbox.hide(cP);
                                            dhtmlx.alert({
                                                title: "提示",
                                                ok: messages["button.ok"],
                                                text: cQ.data == "Y" ? "举报成功": "举报失败",
                                                type: "alert-info"
                                            })
                                        },
                                        error: function(cQ, cS, cR) {
                                            dhtmlx.modalbox.hide(cP)
                                        }
                                    })
                                },
                                checkConfirm: function() {
                                    return true
                                }
                            });
                            $("#608_complain").css("top", "200px")
                        },
                        checkConfirm: function() {
                            return true
                        }
                    });
                    $("#608_check").css("top", "200px")
                } else {
                    dhtmlx.alert({
                        title: "警告",
                        ok: "确定",
                        text: cO,
                        type: "alert-error",
                        callback: function() {
                            var cP = cM.data.result;
                            location_code = cP.split("#")[0];
                            md5Str = cP.split("#")[1];
                            leftTicketStr = cP.split("#")[2];
                            isAsync = cP.split("#")[3];
                            bK(cN, cM.data.isCheckOrderInfo, cM.data.doneHMD)
                        }
                    })
                }
            } else {
                var cL = cM.data.result;
                location_code = cL.split("#")[0];
                md5Str = cL.split("#")[1];
                leftTicketStr = cL.split("#")[2];
                isAsync = cL.split("#")[3];
                bK(cN, cM.data.isCheckOrderInfo, cM.data.doneHMD)
            }
        }
    }
    var T = 0;
    var bh;
    function R() {
        var cL;
        if (rqChecked.length > 1) {
            if (T >= rqChecked.length) {
                T = 0
            }
            cL = rqChecked[T++]
        } else {
            if (train_tour_flag == "fc") {
                cL = $.trim($("#back_train_date").val())
            } else {
                cL = $.trim($("#train_date").val())
            }
        }
        clearInterval(bh);
        bh = window.setInterval(function() {
            if (train_tour_flag == "fc") {
                $("#back_train_date").val(cL)
            } else {
                $("#train_date").val(cL)
            }
            var cM = {
                "leftTicketDTO.train_date": cL,
                "leftTicketDTO.from_station": $("#fromStation").val(),
                "leftTicketDTO.to_station": $("#toStation").val(),
                purpose_codes: cF()
            };
            bc();
            av(cM)
        },
        autoSearchTime)
    }
    function j() {
        if (ifAlertCode && !verifyRandCode($("#randCode_other")[0], true)) {
            return
        }
        var cL = bZ();
        if (cL.length == 0 || tickets_info.length == cL.length / 2) {
            $("#content_autosubmitcheckticketinfo").hide();
            loadGrayBackground();
            if (isAsync == ticket_submit_order.request_flag.isAsync) {
                r()
            } else {
                cJ()
            }
        } else {
            dhtmlx.alert({
                title: "警告",
                ok: "确定",
                text: "您还有未选座的乘客，请选座完成后再提交订单！",
                type: "alert-error",
                callback: function() {}
            })
        }
    }
    function ch() {
        aH();
        cE(tickets_info);
        ab();
        ct();
        $("#i-ok2").hide();
        if (ifAlertCode) {
            refreshImg("passenger", "randp", "other")
        }
        $("#error_msgmypasscode2").hide();
        $("#content_autosubmitcheckticketinfo").show();
        box = dhtmlx.createWin({
            winId: "autosubmitcheckticketinfo",
            closeWinId: ["back_edit"],
            callback: function() {
                clearTimeout(aT);
                jPlayer("stop")
            },
            okId: "qr_submit",
            okCallBack: function() {
                jPlayer("stop");
                if (isAsync == ticket_submit_order.request_flag.isAsync) {
                    r()
                } else {
                    cJ()
                }
            },
            checkConfirm: function() {
                if (!bE()) {
                    return false
                }
                if (!ischeckAutoSubmitCode) {
                    return true
                }
                if (ifAlertCode) {
                    return verifyRandCode($("#randCode_other")[0], true)
                } else {
                    if (isAsync == ticket_submit_order.request_flag.isAsync) {
                        r()
                    } else {
                        cJ()
                    }
                }
            }
        });
        var cM = parseInt(intervalTime / timer_time);
        if (!ifAlertCode) {
            au(timer_time, cM)
        } else {
            var cL = $("#qr_submit1");
            cL.unbind("click");
            cL.removeClass("btn92s").addClass("btn92");
            aS(timer_time, cM)
        
        if (tickets_info.length > 3 && canChooseSeats && "Y" == canChooseSeats) {
            $("#autosubmitcheckticketinfo").css("top", "70px")
        } else {
            $("#autosubmitcheckticketinfo").css("top", "100px")
        }
        $("#autosubmitcheckticketinfo").css("position", "absolute");
        $(".dhx_modal_cover").css("background-color", "#EEEEEE");
        $("#randCode_other").focus()
    }
    var aT;
    function au(cM, cL) {
        if (cM == 0) {
            clearTimeout(aT);
            j();
            return
        } else {
            cM--
        }
        aT = setTimeout(function() {
            au(cM, cL)
        },
        cL)
    }
    var bL;
    function aS(cN, cM) {
        if (cN == 0) {
            clearTimeout(bL);
            var cL = $("#qr_submit1");
            cL.unbind("click").bind("click", j);
            cL.removeClass("btn92").addClass("btn92s");
            return
        } else {
            cN--
        }
        bL = setTimeout(function() {
            aS(cN, cM)
        },
        cM)
    }
    function aV() {
        if (br.length == 0) {
            return
        }
        var cL = bv();
        var cM = cd(cL);
        $("#train_stop").appendTo($("body")).hide();
        $("#queryLeftTable").html("");
        $("#trainum").html("");
        if (cM.length > 0) {
            $("#no_filter_ticket").hide();
            $("#trainum").html(cM.length)
        } else {
            $("#no_filter_ticket").show();
            $("#no_filter_ticket_msg_1").show();
            $("#no_filter_ticket_msg_2").hide();
            $("#trainum").html("0");
            return
        }
        aN(cM)
    }
    function bQ(cM) {
        var cL = cw.createWindow(cM + "_", 0, 0, 660, 100);
        cL.attachObject(cM);
        cL.clearIcon();
        cL.denyResize();
        cL.setModal(true);
        cL.center();
        cL.button("park").hide();
        cL.button("minmax1").hide();
        cL.hideHeader();
        return cL
    }
    function aH() {
        var cQ = new Array();
        $("#autosubmit_check_ticket_tit").html("");
        var cO = $("#train_date").val();
        var cL = bC(new Date(Date.parse(cO.replace(/-/g, "/"))));
        var cM = P.queryLeftNewDTO.station_train_code;
        var cV = null;
        var cW = P.queryLeftNewDTO.from_station_name;
        var cP = P.queryLeftNewDTO.to_station_name;
        var cR = P.queryLeftNewDTO.start_time;
        var cU = P.queryLeftNewDTO.arrive_time;
        var cT = function(cY, c0, cX, c2, cZ, c1, c4, c3) {
            this.date = cY;
            this.week = c0;
            this.station_train_code = cX;
            this.train_headers = c2;
            this.from_station = cZ;
            this.start_time = c1;
            this.to_station = c4;
            this.arrive_time = c3
        };
        var cN = new cT(cO, cL, cM, cV, cW, cR, cP, cU);
        cQ.push(cN);
        var cS = $("#autoSubTicketTitTemplate").html();
        $.templates({
            leftTableTemplate: cS
        });
        $("#autosubmit_check_ticket_tit").html($.render.leftTableTemplate(cQ))
    }
    function n(cX) {
        if (bh) {
            clearInterval(bh)
        }
        var cM = "";
        var cN = "";
        var cS = "";
        var cO = "";
        if ($("#sf2").is(":checked")) {
            cS = "3";
            cO = "学生票"
        }
        tickets_info = new Array();
        var cY = cX[1];
        var cR = cX[2];
        var cQ = 0;
        var cP = passengerChecked.length;
        for (var cT = 0; cT < cR.length; cT++) {
            var cV = 0;
            if (cR[cT].toLowerCase() == "yyrw") {
                var cL = cY.queryLeftNewDTO["seat_types"];
                if (cR[cT].toLowerCase() == "yyrw" && cL.indexOf("A") > -1) {
                    cV = cY.queryLeftNewDTO["gr_num"]
                }
            } else {
                cV = cY.queryLeftNewDTO[cR[cT].toLowerCase() + "_num"]
            }
            if (cV == "--" || cV == "无") {
                cV = 0
            } else {
                if (cV == "有") {
                    cV = 20
                } else {
                    cV = Number(cV)
                }
            }
            if (cQ >= cP) {
                break
            }
            var cW = cR[cT];
            cM = aG(cW);
            cN = O(cW);
            for (var cU = 0; cU < cV; cU++) {
                if (cQ >= cP) {
                    break
                }
                cS = passengerChecked[cU].passenger_type;
                if (!cS || "" == cS) {
                    cS = "1"
                }
                if (cS == "1") {
                    cO = "成人票"
                } else {
                    if (cS == "2") {
                        cO = "儿童票"
                    } else {
                        if (cS == "3") {
                            cO = "学生票"
                        } else {
                            if (cS == "4") {
                                cO = "残军票"
                            }
                        }
                    }
                }
                tickets_info.push(new bs("sdAdd_" + ay(), cM, cN, cS, cO, passengerChecked[cQ].passenger_name, passengerChecked[cQ].passenger_id_type_code, passengerChecked[cQ].passenger_id_type_name, passengerChecked[cQ].passenger_id_no, passengerChecked[cQ].mobile_no));
                cQ++
            }
        }
    }
    function cE(cM) {
        var cL;
        if ("X" == canChooseBeds) {
            $("#bed_show").html("<span style='background:url(../resources/images/icon_new.png) right center no-repeat; padding-right:30px; cursor: pointer;' title='欢迎使用12306选铺功能'>铺别</span>");
            cL = $("#autoSubCheckTicketInfoTemplate_chooseBeds").html().replace("<!--", "").replace("-->", "");
            $("#bed_show").show()
        } else {
            $("#bed_show").hide();
            cL = $("#autoSubCheckTicketInfoTemplate").html()
        }
        $.templates({
            leftTableTemplate: cL
        });
        $("#autosubmit_check_ticketInfo").html($.render.leftTableTemplate(cM))
    }
    function k() {
        var cO = P.queryLeftNewDTO.yz_num;
        var cL = P.queryLeftNewDTO.rz_num;
        var cS = P.queryLeftNewDTO.yw_num;
        var cQ = P.queryLeftNewDTO.rw_num;
        var cR = P.queryLeftNewDTO.gr_num;
        var cP = P.queryLeftNewDTO.ze_num;
        var cU = P.queryLeftNewDTO.zy_num;
        var cV = P.queryLeftNewDTO.tz_num;
        var cM = P.queryLeftNewDTO.swz_num;
        var cT = P.queryLeftNewDTO.wz_num;
        var cN = "";
        if (cO != "--") {
            cN = "YZ";
            return cN
        }
        if (cP != "--") {
            cN = "ZE";
            return cN
        }
        if (cS != "--") {
            cN = "YW";
            return cN
        }
        if (cU != "--") {
            cN = "ZY";
            return cN
        }
        if (cL != "--") {
            cN = "RZ";
            return cN
        }
        if (cQ != "--") {
            cN = "RW";
            return cN
        }
        if (cV != "--") {
            cN = "TZ";
            return cN
        }
        if (cR != "--") {
            cN = "GR";
            return cN
        }
        if (cM != "--") {
            cN = "SWZ";
            return cN
        }
        if (cT != "--") {
            cN = "WZ";
            return cN
        }
    }
    function O(cM) {
        var cL = "";
        if (cM == "ZY") {
            cL = "一等座"
        }
        if (cM == "ZE") {
            cL = "二等座"
        }
        if (cM == "SWZ") {
            cL = "商务座"
        }
        if (cM == "TZ") {
            cL = "特等座"
        }
        if (cM == "YZ") {
            cL = "硬座"
        }
        if (cM == "RZ") {
            cL = "软座"
        }
        if (cM == "YW") {
            cL = "硬卧"
        }
        if (cM == "RW") {
            cL = "软卧"
        }
        if (cM == "GR") {
            cL = "高级软卧"
        }
        if (cM == "SRRB") {
            cL = "动卧"
        }
        if (cM == "YYRW") {
            cL = "高级动卧"
        }
        if (cM == "WZ") {
            cL = "无座"
        }
        return cL
    }
    function aG(cM) {
        var cL = "";
        if (cM == "ZY") {
            cL = "M"
        }
        if (cM == "ZE") {
            cL = "O"
        }
        if (cM == "SWZ") {
            cL = "9"
        }
        if (cM == "TZ") {
            cL = "P"
        }
        if (cM == "YZ") {
            cL = "1"
        }
        if (cM == "RZ") {
            cL = "2"
        }
        if (cM == "YW") {
            cL = "3"
        }
        if (cM == "RW") {
            cL = "4"
        }
        if (cM == "GR") {
            cL = "6"
        }
        if (cM == "WZ") {
            cL = "WZ"
        }
        if (cM == "SRRB") {
            cL = "F"
        }
        if (cM == "YYRW") {
            cL = "A"
        }
        return cL
    }
    function bs(cS, cN, cO, cQ, cP, cM, cU, cT, cR, cL) {
        this.only_id = cS,
        this.seat_type = cN;
        this.seat_type_name = cO;
        this.ticket_type = cQ,
        this.ticket_type_name = cP;
        this.name = cM;
        this.id_type = cU;
        this.id_type_name = cT;
        this.id_no = cR;
        this.phone_no = cL;
        this.toString = function() {
            return this.name + "_" + this.id_type + "_" + this.id_no + "_" + this.phone_no
        }
    }
    function ay() {
        if (tickets_info.length < 1) {
            return tickets_info.length
        } else {
            var cN = 0;
            for (var cM = 0; cM < tickets_info.length; cM++) {
                var cL = Number(tickets_info[cM].only_id.split("_")[1]);
                if (cL > cN) {
                    cN = cL
                }
            }
            return cN + 1
        }
    }
    function bg() {
        b6 = [];
        ae = [];
        aP = [];
        tickets_info = [];
        cb = [];
        cl = [];
        P = "";
        isAsync = "";
        location_code = "";
        md5Str = "";
        leftTicketStr = ""
    }
    getpassengerTicketsForAutoSubmit = function() {
        var cM = "";
        for (var cR = 0; cR < tickets_info.length; cR++) {
            var cS = "";
            if ("WZ" == tickets_info[cR].seat_type) {
                cS = aG(k())
            } else {
                cS = tickets_info[cR].seat_type
            }
            var cP = $("#autosubmit_check_ticketInfo").find("select[id^=ticketype_]");
            var cT = "0";
            if (cP && cP.length > 0) {
                var cL = tickets_info[cR].seat_type + "#" + tickets_info[cR].ticket_type + "#" + tickets_info[cR].name + "#" + tickets_info[cR].id_no;
                for (var cQ = 0,
                cW = cP.length; cQ < cW; cQ++) {
                    var cU = cP.eq(cQ);
                    var cN = cU.val().split("_")[0];
                    var cO = cU.val().split("_")[1];
                    if (cL == cN) {
                        cT = cO
                    }
                }
            }
            var cV = cS + "," + cT + "," + tickets_info[cR].ticket_type + "," + tickets_info[cR].name + "," + tickets_info[cR].id_type + "," + tickets_info[cR].id_no + "," + (tickets_info[cR].phone_no == null ? "": tickets_info[cR].phone_no) + ",N";
            cM += cV + "_"
        }
        return cM.substring(0, cM.length - 1)
    };
    getOldPassengersForAutoSubmit = function() {
        var cN = "";
        for (var cM = 0; cM < passengerChecked.length; cM++) {
            var cL = passengerChecked[cM].passenger_name + "," + passengerChecked[cM].passenger_id_type_code + "," + passengerChecked[cM].passenger_id_no + "," + passengerChecked[cM].passenger_type;
            cN += cL + "_"
        }
        return cN
    };
    var a2 = false;
    function bK(cL, cM) {
        var cQ = "";
        var cN = $("#train_date").val().split("-");
        var cO = new Date();
        cO.setFullYear(cN[0], cN[1] - 1, cN[2]);
        if (isAsync == ticket_submit_order.request_flag.isAsync && leftTicketStr != "") {
            var cP = null;
            if (tickets_info[0].seat_type == "WZ") {
                if (P.queryLeftNewDTO.yz_num != "--") {
                    tickets_info[0].seat_type = "1";
                    a2 = true;
                    tickets_info[0].seat_type_name = "硬座"
                } else {
                    if (P.queryLeftNewDTO.ze_num != "--") {
                        tickets_info[0].seat_type = "O";
                        a2 = true;
                        tickets_info[0].seat_type_name = "二等座"
                    }
                }
            }
            $.ajax({
                url: ctx + "confirmPassenger/getQueueCountAsync",    
                type: "post",
                async: false,
                data: {
                    train_date: cO.toString(),
                    train_no: P.queryLeftNewDTO.train_no,
                    stationTrainCode: P.queryLeftNewDTO.station_train_code,
                    seatType: tickets_info[0].seat_type,
                    fromStationTelecode: P.queryLeftNewDTO.from_station_telecode,
                    toStationTelecode: P.queryLeftNewDTO.to_station_telecode,
                    leftTicket: leftTicketStr,
                    purpose_codes: cL,
                    isCheckOrderInfo: cM
                },
                dataType: "json",
                success: function(cT) {
                    if (cT.status) {
                        if (cT.data.isRelogin == "Y") {
                            window.location.href = ctx + "view/index.html?random=" + new Date().getTime()
                        }
                        var cU = null;
                        var cS = tickets_info[0].seat_type;
                        cU = cT.data.ticket.split(",");
                        cQ = "本次列车，" + (tickets_info[0].seat_type_name).split("（")[0] + "余票";
                        if (parseInt(cU[0]) >= 0) {
                            cQ += "<strong>" + cU[0] + "</strong>张"
                        } else {
                            cQ += cU[0]
                        }
                        var cR = false;
                        if (cU.length > 1) {
                            cQ += ",无座余票";
                            if (parseInt(cU[1]) >= 0) {
                                cQ += "<strong>" + cU[1] + "</strong>张"
                            } else {
                                cQ += cU[1]
                            }
                            cR = true
                        }
                        cQ += "。";
                        if (cT.data.op_2 == "true") {
                            if ((a2 && !cR) || !a2) {
                                a5 = false;
                                R();
                                return
                            }
                            cQ += '<font color="red">目前排队人数已经超过余票张数，请您选择其他席别或车次。</font>'
                        } else {
                            if (cT.data.countT > 0) {
                                cQ += '目前排队人数<font color="red">' + cT.data.countT + "</font>人，";
                                if (if_show_pass_code_login == "Y") {
                                    cQ += "<br/>请确认以上信息是否正确，点击“确认”后，系统将为您分配席位。"
                                }
                            }
                        }
                        var cV = $("#sy_ticket_num_id");
                        if (cV != null) {
                            cV.html(cQ)
                        }
                        ch()
                    }
                },
                error: function(cR, cT, cS) {
                    return
                }
            })
        } else {
            ch()
        }
    }
    function bM(cM, cL) {
        rt = "";
        seat_1 = -1;
        seat_2 = -1;
        i = 0;
        while (i < cM.length) {
            s = cM.substr(i, 10);
            c_seat = s.substr(0, 1);
            if (c_seat == cL) {
                count = s.substr(6, 4);
                while (count.length > 1 && count.substr(0, 1) == "0") {
                    count = count.substr(1, count.length)
                }
                count = parseInt(count);
                if (count < 3000) {
                    seat_1 = count
                } else {
                    seat_2 = (count - 3000)
                }
            }
            i = i + 10
        }
        if (seat_1 > -1) {
            rt += seat_1
        }
        if (seat_2 > -1) {
            rt += "," + seat_2
        }
        return rt
    }
    function cJ() {
        $.ajax({
            url: ctx + "confirmPassenger/confirmSingle",
            type: "post",
            data: {
                passengerTicketStr: getpassengerTicketsForAutoSubmit(),
                oldPassengerStr: getOldPassengersForAutoSubmit(),
                tour_flag: "dc",
                randCode: $("#randCode_other").val(),
                purpose_codes: cF(),
                key_check_isChange: md5Str,
                train_location: location_code,
                choose_seats: bZ(),
                seatDetailType: a1()
            },
            dataType: "json",
            async: true,
            success: function(cL) {
                if (cL.status) {
                    if (cL.data.submitStatus) {
                        otsRedirect("post", ctx + "payOrder/init?random=" + new Date().getTime(), {})
                    } else {
                        am("出票失败!", false, "原因： " + cL.data.errMsg + '<a  id="xg_close_win_id">点击修改</a>', true, "lose");
                        $("#xg_close_win_id").click(function() {
                            ap("transforNotice_id", true);
                            $("#i-ok").css("display", "none")
                        })
                    }
                } else {
                    am("订票失败!", true, "很抱歉！请关闭窗口重新预定车票", true, "lose")
                }
            },
            error: function(cL, cN, cM) {
                am("订票失败!", true, "很抱歉！网络忙，请关闭窗口稍后再试。", true, "lose");
                return
            }
        })
    }
    function r() {
        $.ajax({
            url: ctx + "confirmPassenger/confirmSingleForQueueAsys",
            type: "post",
            data: {
                passengerTicketStr: getpassengerTicketsForAutoSubmit(),
                oldPassengerStr: getOldPassengersForAutoSubmit(),
                randCode: $("#randCode_other").val(),
                purpose_codes: cF(),
                key_check_isChange: md5Str,
                leftTicketStr: leftTicketStr,
                train_location: location_code,
                choose_seats: bZ(),
                seatDetailType: a1()
            },
            dataType: "json",
            async: true,
            success: function(cL) {
                $("#i-ok").css("display", "none");
                $("#i-ok2").css("display", "none");
                $("#c_error2").html("");
                $("#c_error2").removeClass("error");
                $("#randCode2").val("");
                if (cL.status) {
                    if (!cL.data.submitStatus) {
                        am("出票失败!", false, "原因： " + cL.data.errMsg + '<a id="xg_close_win_id" >点击修改</a>', true, "lose");
                        $("#xg_close_win_id").click(function() {
                            ap("transforNotice_id", true)
                        });
                        if (cL.data.errMsg.indexOf("余票不足") >= 0) {
                            jPlayer("stop");
                            $("#qr_closeTranforDialog_id").click();
                            $("#query_ticket").click()
                        }
                    } else {
                        var cM = new OrderQueueWaitTime("dc", az, v);
                        cM.start(queryOrderWaitTimeInterval)
                    }
                } else {
                    am("订票失败!", true, "很抱歉！请关闭窗口重新预定车票", true, "lose")
                }
            },
            error: function(cL, cN, cM) {
                am("订票失败!", true, "很抱歉！网络忙，请关闭窗口稍后再试。", true, "lose");
                return
            }
        })
    }
    function az(cL, cN, cM) {
        if (cN <= 5) {
            am("订单已经提交，系统正在处理中，请稍等。", false, "", false, "work")
        } else {
            if (cN > 30 * 60) {
                am("订单已经提交，预计等待时间超过30分钟，请耐心等待。", false, "", false, "queue")
            } else {
                am("订单已经提交，最新预估等待时间" + cM + "，请耐心等待。", false, "", false, "queue")
            }
        }
    }
    function v(cL, cN, cM) {
        if (cN == -1 || cN == -100) {
            $.ajax({
                url: ctx + "confirmPassenger/resultOrderForDcQueue",
                data: {
                    orderSequence_no: cM.orderId
                },
                type: "POST",
                dataType: "json",
                success: function(cO) {
                    if (cO.status) {
                        if (cO.data.submitStatus) {
                            otsRedirect("post", ctx + "/payOrder/init?random=" + new Date().getTime(), {})
                        } else {
                            am("下单成功", false, "", false, "win")
                        }
                    } else {
                        am("下单成功。", false, "", false, "win")
                    }
                },
                error: function(cO, cQ, cP) {
                    am("下单成功。", false, "", false, "win")
                }
            })
        } else {
            b4(cN, cM)
        }
    }
    function b4(cL, cM) {
        if (cM.name && cM.card && cM.tel) {
            ap("transforNotice_id", true);
            $("#608_check_msg").html(cM.msg);
            dhtmlx.createWin({
                winId: "608_check",
                closeWinId: ["608_check_close", "608_check_cancel"],
                okId: "608_check_ok",
                okCallBack: function() {
                    $("#608_name").html(cM.name);
                    $("#608_card").html(cM.card);
                    $("#608_tel").html(cM.tel);
                    $("#ticketInfo").html(cM.ticketInfo);
                    dhtmlx.createWin({
                        winId: "608_complain",
                        closeWinId: ["608_complain_close", "608_complain_cancel"],
                        okId: "608_complain_ok",
                        okCallBack: function() {
                            var cN = dhtmlx.modalbox({
                                targSrc: '<div><img src="' + ctx + 'resources/images/loading.gif"></img></div>',
                                callback: function() {}
                            });
                            $.ajax({
                                url: ctx + "confirmPassenger/report",
                                type: "post",
                                async: false,
                                success: function(cO) {
                                    dhtmlx.modalbox.hide(cN);
                                    if (cO.data == "Y") {
                                        dhtmlx.alert({
                                            title: "提示",
                                            ok: messages["button.ok"],
                                            text: "举报成功",
                                            type: "alert-info"
                                        })
                                    } else {
                                        dhtmlx.alert({
                                            title: "提示",
                                            ok: messages["button.ok"],
                                            text: "举报失败",
                                            type: "alert-error"
                                        })
                                    }
                                    $("#i-okmypasscode1").hide();
                                    if (ifAlertCode) {
                                        refreshImg("passenger", "randp", "other")
                                    }
                                },
                                error: function(cO, cQ, cP) {
                                    dhtmlx.modalbox.hide(cN)
                                }
                            })
                        },
                        checkConfirm: function() {
                            return true
                        }
                    });
                    $("#608_complain").css("top", "200px")
                },
                checkConfirm: function() {
                    return true
                },
                callback: function() {
                    $("#i-okmypasscode1").hide();
                    if (ifAlertCode) {
                        refreshImg("passenger", "randp", "other")
                    }
                }
            });
            $("#608_check").css("top", "200px");
            return
        }
        if (cL == -1) {
            return
        } else {
            if (cL == -2) {
                if (cM.errorcode == 0) {
                    am("订票失败!", true, "原因： " + cM.msg, true, "lose")
                } else {
                    am("订票失败!", true, "原因： " + cM.msg, true, "lose")
                }
                if (cM.msg.indexOf("没有足够的票") > -1) {
                    jPlayer("stop");
                    $("#qr_closeTranforDialog_id").click();
                    $("#query_ticket").click()
                }
            } else {
                if (cL == -3) {
                    am("哎呀,订票失败!", true, "订单已撤销", true, "lose")
                } else {
                    window.location.href = ctx + "view/train_order.html?type=1&random=" + new Date().getTime()
                }
            }
        }
    }
    function Y() {
        cD = new dhtmlXWindows();
        cD.enableAutoViewport(true);
        cD.setSkin("dhx_terrace");
        cD.setImagePath(ctx + "resources/js/rich/windows/imgs/");
        ap = function(cP, cO) {
            unLoadGrayBackground();
            if (cD.isWindow(cP + "_")) {
                cD.window(cP + "_").setModal(false);
                cD.window(cP + "_").hide()
            }
        };
        am = function(cV, cS, cP, cO, cR) {
            var cU = '<div class="tit">' + (cS ? '<span class="colorC">' + cV + "</span>": cV) + "</div>";
            var cQ = "<P>" + cP + "</p>";
            var cT = cS ? '<p>请点击[<a href="' + ctx + 'view/train_order.html?type=2"><strong>我的12306</strong></a>]办理其他业务。您也可以点击[<a href="' + ctx + 'leftTicket/init"><strong>预订车票</strong></a>]，重新规划您的旅程。</p>': '<P>查看订单处理情况，请点击“<a href="' + ctx + 'view/train_order.html?type=1">未完成订单</a>”</P>';
            $("#iamge_status_id").removeClass().addClass("icon i-" + cR);
            if (cO) {
                $("#up-box-hd_id").html("提示<a id='closeTranforDialog_id' href='#nogo'>关闭</a>");
                cT = "";
                $("#lay-btn_id").html("<a href='#nogo' id='qr_closeTranforDialog_id'  class='btn92s'>确认</a>")
            } else {
                $("#up-box-hd_id").html("提示");
                $("#lay-btn_id").html("")
            }
            $("#orderResultInfo_id").html(cU + (cP == "" || cP == null || cP == "undefined" || cP == undefined ? "": cQ) + cT);
            cL("transforNotice_id");
            if (cO) {
                $("#closeTranforDialog_id").click(function() {
                    ap("transforNotice_id", true)
                });
                $("#qr_closeTranforDialog_id").click(function() {
                    ap("transforNotice_id", true);
                    $("#i-ok").css("display", "none")
                })
            }
        };
        function cL(cS) {
            ap(cS, false);
            if ("checkticketinfo_id" == cS) {
                var cQ = ticketInfoForPassengerForm.queryLeftNewDetailDTO;
                if (cQ.to_station_telecode == ticket_submit_order.special_areas.lso || cQ.to_station_telecode == ticket_submit_order.special_areas.dao || cQ.to_station_telecode == ticket_submit_order.special_areas.ado || cQ.to_station_telecode == ticket_submit_order.special_areas.nqo || cQ.to_station_telecode == ticket_submit_order.special_areas.tho) {
                    if (cM()) {
                        $("#notice_1_id").html("1.系统将随机为您申请席位，暂不支持自选席位。");
                        $("#notice_2_id").html("2.根据现行规定，外国人在购买进西藏火车票时，须出示西藏自治区外事办公室或旅游局、商务厅的批准函（电），或者出示中国内地司局级接待单位出具的、已征得自治区上述部门同意的证明信函。台湾同胞赴藏从事旅游、商务活动，须事先向西藏自治区旅游局或商务厅提出申请，购买进藏火车票时须出示有关批准函。");
                        if (cN()) {
                            $("#notice_3_id").html("3.按现行规定，学生票购票区间必须与学生证上的乘车区间一致，否则车站将不予换票。")
                        } else {
                            $("#notice_3_id").html("")
                        }
                    }
                } else {
                    $("#notice_1_id").html("1.系统将随机为您申请席位，暂不支持自选席位。");
                    if (cN()) {
                        $("#notice_3_id").html("2.按现行规定，学生票购票区间必须与学生证上的乘车区间一致，否则车站将不予换票。")
                    } else {
                        $("#notice_3_id").html("")
                    }
                }
            }
            var cP = bl(cS);
            var cO = $(window).width() / 2 - 300;
            var cR = cC() + ($(window).height() / 2 - 200);
            cP.setDimension($("#content_" + cS).width(), $("#content_" + cS).height() + 10);
            $(".dhtmlx_window_active").height($("#content_" + cS).height());
            $(".dhtmlx_window_active").css({
                left: cO + "px",
                top: cR + "px"
            })
        }
        function cN() {
            for (var cP = 0; cP < limit_tickets.length; cP++) {
                var cO = limit_tickets[cP];
                if (cO.ticket_type == ticket_submit_order.ticket_type.student) {
                    return true
                }
            }
            return false
        }
        function cM() {
            for (var cP = 0; cP < limit_tickets.length; cP++) {
                var cO = limit_tickets[cP];
                if ((ticketInfoForPassengerForm.tour_flag == ticket_submit_order.tour_flag.fc || ticketInfoForPassengerForm.tour_flag == ticket_submit_order.tour_flag.gc) && cO.save_status != "" && (cO.id_type == ticket_submit_order.passenger_card_type.passport || cO.id_type == ticket_submit_order.passenger_card_type.work || cO.id_type == ticket_submit_order.passenger_card_type.taiwan)) {
                    return true
                } else {
                    if ((ticketInfoForPassengerForm.tour_flag == ticket_submit_order.tour_flag.wc || ticketInfoForPassengerForm.tour_flag == ticket_submit_order.tour_flag.dc) && (cO.id_type == ticket_submit_order.passenger_card_type.passport || cO.id_type == ticket_submit_order.passenger_card_type.work || cO.id_type == ticket_submit_order.passenger_card_type.taiwan)) {
                        return true
                    }
                }
            }
            return false
        }
    }
    function bl(cM) {
        var cL = cD.createWindow(cM + "_", 0, 0, 660, 100);
        cL.attachObject(cM);
        cL.clearIcon();
        cL.denyResize();
        cL.setModal(true);
        cL.center();
        cL.button("park").hide();
        cL.button("minmax1").hide();
        cL.hideHeader();
        return cL
    }
    function G(cM) {
        var cL = new Date();
        var cN = cM.split("-");
        cL.setFullYear(parseInt(cN[0]), parseInt(cN[1] - 1, 10), parseInt(cN[2], 10));
        if (cN.length >= 6) {
            cL.setHours(cN[3], cN[4], cN[5])
        }
        return cL
    }
    function aQ(cL) {
        var cO = "",
        cN = "";
        var cQ = cL.replace(/-/g, "");
        if (cQ.substring(4, 5) == "0") {
            cO = cQ.substring(5, 6) + "月"
        } else {
            cO = cQ.substring(4, 6) + "月"
        }
        if (cQ.substring(6, 7) == "0") {
            cN = cQ.substring(7, 8) + "日"
        } else {
            cN = cQ.substring(6, 8) + "日"
        }
        var cM = new Date(Date.parse(cL.replace(/-/g, "/")));
        var cP = "日一二三四五六";
        return cO.concat(cN).concat("&nbsp;&nbsp;").concat("周").concat(cP.charAt(cM.getDay()))
    }
    function d() {
        $(".buy-cart .close").on("click",
        function() {
            $(".cart-bd").hide()
        });
        $(".cart-hd").on("click",
        function() {
            $(this).next(".cart-bd").toggle()
        });
        $("#hbClear").click(function() {
            var cM = $(".cart-tlist li");
            for (var cL = 0; cL < cM.length; cL++) {
                deleteHB($(cM[cL]).find("a"))
            }
        });
        $("#hbSubmit").click(function() {
            var cP = $(".cart-tlist li");
            var cO = "";
            if (cP.length == 0) {
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: "请先选择候补车次！",
                    type: "alert-error"
                });
                return
            }
            for (var cM = 0; cM < cP.length; cM++) {
                var cN = seatTypeForHB[$(cP[cM]).attr("hbid").split("#")[4].split("_")[0]].split("_")[0];
                var cL = $(cP[cM]).attr("hbid").split("#")[9] + "#" + cN + "|";
                cO += cL
            }
            V(cO)
        })
    }
    function aM(cM, cN) {
        var cL = dhtmlx.modalbox({
            targSrc: '<div><img src="' + ctx + 'resources/images/loading.gif"></img></div>'
        });
        $.ajax({
            type: "post",
            url: ctx + "login/checkUser",
            data: {},
            beforeSend: function(cO) {
                cO.setRequestHeader("If-Modified-Since", "0");
                cO.setRequestHeader("Cache-Control", "no-cache")
            },
            success: function(cO) {
                dhtmlx.modalbox.hide(cL);
                if (cO.data.flag) {
                    if (cN && typeof cN === "function") {
                        cN()
                    }
                } else {
                    aY(function() {
                        a4(cM)
                    })
                }
            },
            error: function() {
                dhtmlx.modalbox.hide(cL);
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: "系统忙，请稍后再试！",
                    type: "alert-error"
                })
            }
        })
    }
    function aY(cL) {
        $(".mask").fadeIn();
        $(".login-box .login-hd-code").addClass("active").siblings().removeClass("active");
        $(".login-box .login-code").show().siblings().hide();
        $(".login-box").slide({
            titCell: ".login-hd li",
            mainCell: ".login-bd",
            titOnClassName: "active",
            trigger: "click",
        });
        $(".modal-login").css("top", ($(window).height() - $(".modal-login").height()) / 2 + $(window).scrollTop() + "px").css("left", ($(window).width() - $(".modal-login").width()) / 2 + $(window).scrollLeft() + "px").show();
        $.popup_initLogin(true);
        $(".modal-login").fadeIn();
        $.pop_callback = function() {
            if (cL && typeof cL === "function") {
                cL()
            }
        }
    }
    var bb = false;
    var J;
    var a0 = 0;
    function al(cN, cQ) {
        if (bb) {
            var cM = new Date().getTime();
            if (cM - J <= a0) {
                if (cQ && typeof cQ === "function") {
                    cQ()
                }
                return true
            }
        }
        var cP = seatTypeForHB[$(cN).attr("hbid").split("#")[4].split("_")[0]].split("_")[0];
        var cO = $(cN).attr("hbid").split("#")[9] + "#" + cP + "|";
        var cL = al;
        $.ajax({
            type: "post",
            url: ctx + "afterNate/chechFace",
            data: {
                secretList: cO
            },
            async: false,
            beforeSend: function(cR) {
                cR.setRequestHeader("If-Modified-Since", "0");
                cR.setRequestHeader("Cache-Control", "no-cache")
            },
            success: function(cR) {
                var cS = cR.data;
                if (cS) {
                    if (cS.login_flag) {
                        if (cS.face_flag == false) {
                            bB(cS.face_check_code)
                        } else {
                            bb = true;
                            J = new Date().getTime();
                            if (cQ && typeof cQ === "function") {
                                cQ()
                            }
                            return true
                        }
                    } else {
                        aY(function() {
                            cL(cN, cQ);
                            return true
                        })
                    }
                } else {
                    dhtmlx.alert({
                        title: "提示",
                        ok: "确定",
                        text: cR.messages[0],
                        type: "alert-error"
                    })
                }
            },
            error: function() {
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: "系统忙，请稍后再试！",
                    type: "alert-error"
                })
            }
        });
        return false
    }
    function V(cL) {
        aM(cL,
        function() {
            a4(cL)
        })
    }
    function a4(cL) {
        $.ajax({
            type: "POST",
            url: ctx + "afterNate/submitOrderRequest",
            data: {
                secretList: cL
            },
            timeout: 10000,
            error: function(cM, cO, cN) {
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: "系统忙，请稍后再试！",
                    type: "alert-error"
                })
            },
            success: function(cM) {
                var cN = cM.data;
                if (cN) {
                    if (cN.flag) {
                        otsRedirect("get", window.location.protocol + "//" + window.location.host + "/" + href_path_2 + "view/lineUp_toPay.html", {})
                    } else {
                        bB(cN.faceCheck)
                    }
                } else {
                    dhtmlx.alert({
                        title: "提示",
                        ok: "确定",
                        text: cM.messages[0],
                        type: "alert-error"
                    })
                }
            }
        })
    }
    function bB(cM) {
        if (cM == "01" || cM == "11") {
            var cL = "证件信息正在审核中，请您耐心等待，审核通过后可继续完成候补操作。</P>";
            dhtmlx.alert({
                title: "提示",
                ok: "确定",
                text: "身份核验审核中",
                body: cL,
                type: "alert-error"
            })
        } else {
            if (cM == "03" || cM == "13") {
                var cL = "证件信息审核失败，请检查所填写的身份信息内容与原证件是否一致。";
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: '<span class="colorC">审核失败</span>',
                    body: cL,
                    type: "alert-error"
                })
            } else {
                if (cM == "04" || cM == "14") {
                    var cL = "通过人证一致性核验的用户及激活的“铁路畅行”会员可以提交候补需求，请您按照操作说明在铁路12306app上完成人证核验";
                    dhtmlx.alert({
                        title: "提示",
                        ok: "确定",
                        text: "身份核验提醒",
                        body: cL,
                        type: "alert-error"
                    })
                } else {
                    if (cM == "02" || cM == "12") {} else {
                        dhtmlx.alert({
                            title: "提示",
                            ok: "确定",
                            text: "系统忙，请稍后再试！",
                            type: "alert-error"
                        })
                    }
                }
            }
        }
    }
    function bU(cM) {
        var cN = $(cM).attr("hbid");
        if ($(cM).hasClass("item-cphd cphd-active")) {
            if ($(cM).prev().hasClass("cphd-active-prev")) {
                $(cM).prev().removeClass()
            }
            if ($(cM).next().hasClass("item-cphd cphd-active")) {
                $(cM).attr("class", "item-cphd cphd-active-prev")
            } else {
                $(cM).removeClass()
            }
            x(cN, "del")
        } else {
            var cL = cN.split("#")[0];
            if ($('.cart-tlist li[tdate="' + cL + '"]').length == alowHBMaxNum) {
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: hb_max_msg,
                    type: "alert-error"
                });
                return
            }
            al(cM,
            function() {
                $(cM).attr("class", "item-cphd cphd-active");
                if (!$(cM).prev().hasClass("cphd-active")) {}
                x(cN, "add");
                u(cM, cN)
            })
        }
    }
    function x(cR, cO) {
        var cN = cR.split("#");
        if (cO == "add") {
            $(".buy-cart").show();
            var cP = '<li tdate="' + cN[0] + '" hbid="' + cR + '"><div>' + cN[0] + "    " + cN[6] + "  -  " + cN[8] + "</div><div>" + cN[10] + " | " + seatTypeForHB[cN[4].split("_")[0]].split("_")[1] + ' <span style="display:none;"></span></div><div name="suc_rate" hbid="' + cR + '" class="cart-odds"></div><a href="javascript:void(0)" onclick="deleteHB(this)" class="del">删除</a></li>';
            $(".cart-tlist").append(cP);
            var cM = seatTypeForHB[cR.split("#")[4].split("_")[0]].split("_")[0];
            var cQ = cR.split("#")[9] + "#" + cM;
            bO(cQ, cR)
        } else {
            $('li[hbid="' + cR + '"]').remove()
        }
        $(".cart-hd span").html($(".cart-tlist li").length);
        if ($(".cart-tlist li").length == 0) {
            $(".cart-bd").hide()
        } else {
            var cL = $($(".cart-tlist li")[0]).attr("hbid").split("#")[0];
            $(".cart-bd").show()
        }
    }
    function u(cN, cP) {
        var cO = $(".cart-hd").offset();
        var cQ = $(cN).offset();
        var cL = $('<img id="flyer" src="' + ctx + 'resources/images/oval.png" style="overflow:hidden;position:absolute;z-index:1500;" width="11" height="11" />');
        try {
            cL.fly({
                start: {
                    left: cQ.left + 27,
                    top: cQ.top - $(window).scrollTop() + 10
                },
                end: {
                    left: cO.left + 10,
                    top: cO.top - $(window).scrollTop() + 10,
                    width: 0,
                    height: 0
                },
                onEnd: function() {
                    this.destory()
                },
                autoPlay: true,
                speed: 1.7,
                vertex_Rtop: 100
            })
        } catch(cM) {}
    }
    function bO(cL, cM) {
        $.ajax({
            type: "POST",
            url: ctx + "afterNate/getSuccessRate",
            data: {
                successSecret: cL
            },
            timeout: 10000,
            error: function(cN, cP, cO) {},
            success: function(cN) {
                var cO = cN.data;
                if (cO && cO.flag) {
                    var cP = cO.flag[0];
                    if (cP.level == 3) {
                        $('div[name="suc_rate"][hbid="' + cM + '"]').after('<span class="odds-small">' + cP.info + "</span>")
                    } else {
                        if (cP.level == 2) {
                            $('div[name="suc_rate"][hbid="' + cM + '"]').after('<span class="odds-mid">' + cP.info + "</span>")
                        } else {
                            if (cP.level == 1) {
                                $('div[name="suc_rate"][hbid="' + cM + '"]').after('<span class="odds-large">' + cP.info + "</span>")
                            }
                        }
                    }
                }
            }
        })
    }
    deleteHB = function(cM) {
        $(cM).parent().remove();
        var cN = $(cM).parent().attr("hbid");
        var cL = $('td[hbid="' + cN + '"]');
        if ($(cL).prev().hasClass("cphd-active-prev")) {
            $(cL).prev().removeClass()
        }
        if ($(cL).next().hasClass("item-cphd cphd-active")) {
            $(cL).attr("class", "item-cphd cphd-active-prev")
        } else {
            $(cL).removeClass()
        }
        U()
    };
    function U() {
        $(".cart-hd span").html($(".cart-tlist li").length);
        if ($(".cart-tlist li").length == 0) {
            $(".cart-bd").hide()
        } else {
            var cL = $($(".cart-tlist li")[0]).attr("hbid").split("#")[0];
            $(".cart-bd").show()
        }
    }
    showTicketPrice = function(cP) {
        if ($(cP).html() == "候补" && $(cP).attr("ifAlow_MaxLength") == "1") {
            bU(cP);
            return
        }
        var cT = $(cP).parent("tr").children("td").children("div").children("div").children("span").attr("id");
        if (undefined == cT || cT == null || "undefined" == typeof(cT)) {
            cT = $(cP).attr("id")
        }
        $("#price_" + cQ).hide();
        $("#tp-list-price").hide();
        $("#sleeper-price>span").css("cursor", "pointer");
        var cQ = cT.split("_")[0];
        var cR = $("#price_" + cQ).attr("datatran");
        var cS = cT.split("_")[1];
        var cO = cT.split("_")[2];
        var cU = cT.split("_")[3];
        var cN = cT.split("_")[4];
        var cL = $("#WZ_" + cQ).html();
        var cM = $("#QT_" + cQ).html();
        if (cN && ($("#ticket_" + cQ + "_train>span>span").text() == "查看票价")) {
            if ($("#ticket_" + cQ).attr("class") == "bgc") {
                $("#price_" + cQ).addClass("bgc")
            }
            $.ajax({
                type: "get",
                isTakeParam: false,
                beforeSend: function(cV) {
                    cV.setRequestHeader("If-Modified-Since", "0");
                    cV.setRequestHeader("Cache-Control", "no-cache")
                },
                url: ctx + "leftTicket/queryTicketPriceFL",
                data: {
                    train_no: cQ,
                    from_station_no: cS,
                    to_station_no: cO,
                    seat_types: cN,
                    train_date: train_tour_flag == "fc" ? $.trim($("#back_train_date").val()) : $.trim($("#train_date").val())
                },
                timeout: 1000,
                error: function(cV, cX, cW) {},
                success: function(cV) {}
            });
            $.ajax({
                type: "get",
                isTakeParam: false,
                beforeSend: function(cV) {
                    cV.setRequestHeader("If-Modified-Since", "0");
                    cV.setRequestHeader("Cache-Control", "no-cache")
                },
                url: ctx + "leftTicket/queryTicketPrice",
                data: {
                    train_no: cQ,
                    from_station_no: cS,
                    to_station_no: cO,
                    seat_types: cN,
                    train_date: train_tour_flag == "fc" ? $.trim($("#back_train_date").val()) : $.trim($("#train_date").val())
                },
                success: function(cV) {
                    if (cV.status) {
                        $("#ticket_" + cQ + "_train>span>span").html("收起票价");
                        $("#ticket_" + cQ + "_train>span>b").addClass("open");
                        $("#ticket_" + cQ + "_train>span>b").attr("title", "收起票价");
                        if (cM == "--") {
                            cV.data.MIN = ""
                        }
                        if (cL == "--") {
                            cV.data.WZ = ""
                        }
                        $("#price_" + cQ).html($.render.priceTableTemplate(cV.data));
                        $("#price_" + cQ).show();
                        if (cR && c(cR)) {
                            $("#price_" + cQ).find("td").eq(0).html('<a class="ad-tlist-hot" href="javascript:void(0);">移动宾馆 免费晚餐 快捷舒适 准时正点</a>')
                        } else {
                            $("#price_" + cQ).find("td").eq(0).html("")
                        }
                        if (cV.data.PM != "--") {
                            $("#sleeper-price_" + cQ).mouseover(function() {
                                $("#tp-list-price_" + cQ).show()
                            });
                            $("#sleeper-price_" + cQ).mouseout(function() {
                                $("#tp-list-price_" + cQ).hide()
                            })
                        }
                    }
                }
            })
        } else {
            $("#ticket_" + cQ + "_train>span>span").html("查看票价");
            $("#ticket_" + cQ + "_train>span>b").attr("title", "查看票价");
            $("#ticket_" + cQ + "_train>span>b").removeClass();
            $("#price_" + cQ).html("");
            $("#price_" + cQ).hide()
        }
    };
    function cd(cL) {
        if (aK == "starttime") {
            return cL.sort(function(cN, cM) {
                var cP = Number(cN.queryLeftNewDTO.start_time.replace(":", ""));
                var cO = Number(cM.queryLeftNewDTO.start_time.replace(":", ""));
                if (cP > cO) {
                    return bk ? 1 : -1
                } else {
                    return bk ? -1 : 1
                }
            })
        } else {
            if (aK == "arrivedtime") {
                return cL.sort(function(cN, cM) {
                    var cP = Number(cN.queryLeftNewDTO.arrive_time.replace(":", ""));
                    var cO = Number(cM.queryLeftNewDTO.arrive_time.replace(":", ""));
                    if (cP > cO) {
                        return co ? 1 : -1
                    } else {
                        return co ? -1 : 1
                    }
                })
            } else {
                if (aK == "lishi") {
                    return cL.sort(function(cN, cM) {
                        var cP = Number(cN.queryLeftNewDTO.lishi.replace(":", ""));
                        var cO = Number(cM.queryLeftNewDTO.lishi.replace(":", ""));
                        if (cP > cO) {
                            return bf ? 1 : -1
                        } else {
                            return bf ? -1 : 1
                        }
                    })
                }
            }
        }
        return cL
    }
    function aL() {
        $("#s_time").click(function() {
            if (bk) {
                $("#s_time").removeClass().addClass("b4");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                bk = false;
                $("#other_span_starttime").removeClass().addClass("b4");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            } else {
                $("#s_time").removeClass().addClass("b3");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                bk = true;
                $("#other_span_starttime").removeClass().addClass("b3");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            }
            aK = "starttime";
            aV()
        });
        $("#other_span_starttime").click(function() {
            if (bk) {
                $("#s_time").removeClass().addClass("b4");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                bk = false;
                $("#other_span_starttime").removeClass().addClass("b4");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            } else {
                $("#s_time").removeClass().addClass("b3");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                bk = true;
                $("#other_span_starttime").removeClass().addClass("b3");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            }
            aK = "starttime";
            aV()
        });
        $("#r_time").click(function() {
            if (co) {
                $("#r_time").removeClass().addClass("b4");
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                co = false;
                $("#other_span_starttime").removeClass().addClass("b4");
                $("#other_span_endtime").removeClass().addClass("b2");
                $("#other_span_lishi").removeClass().addClass("b2")
            } else {
                $("#r_time").removeClass().addClass("b3");
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                co = true;
                $("#other_span_endtime").removeClass().addClass("b2");
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            }
            aK = "arrivedtime";
            aV()
        });
        $("#other_span_endtime").click(function() {
            if (co) {
                $("#r_time").removeClass().addClass("b4");
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                co = false;
                $("#other_span_endtime").removeClass().addClass("b4");
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            } else {
                $("#r_time").removeClass().addClass("b3");
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                if ($("#l_s").attr("class") == "b4") {
                    $("#l_s").removeClass().addClass("b2")
                } else {
                    if ($("#l_s").attr("class") == "b3") {
                        $("#l_s").removeClass().addClass("b1")
                    }
                }
                co = true;
                $("#other_span_endtime").removeClass().addClass("b3");
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_lishi").attr("class") == "b4") {
                    $("#other_span_lishi").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_lishi").attr("class") == "b3") {
                        $("#other_span_lishi").removeClass().addClass("b1")
                    }
                }
            }
            aK = "arrivedtime";
            aV()
        });
        $("#l_s").click(function() {
            if (bf) {
                $("#l_s").removeClass().addClass("b4");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                bf = false;
                $("#other_span_lishi").removeClass().addClass("b4");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
            } else {
                $("#l_s").removeClass().addClass("b3");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                bf = true;
                $("#other_span_lishi").removeClass().addClass("b3");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
            }
            aK = "lishi";
            aV()
        });
        $("#other_span_lishi").click(function() {
            if (bf) {
                $("#l_s").removeClass().addClass("b4");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                bf = false;
                $("#other_span_lishi").removeClass().addClass("b4");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
            } else {
                $("#l_s").removeClass().addClass("b3");
                if ($("#r_time").attr("class") == "b4") {
                    $("#r_time").removeClass().addClass("b2")
                } else {
                    if ($("#r_time").attr("class") == "b3") {
                        $("#r_time").removeClass().addClass("b1")
                    }
                }
                if ($("#s_time").attr("class") == "b4") {
                    $("#s_time").removeClass().addClass("b2")
                } else {
                    if ($("#s_time").attr("class") == "b3") {
                        $("#s_time").removeClass().addClass("b1")
                    }
                }
                bf = true;
                $("#other_span_lishi").removeClass().addClass("b3");
                if ($("#other_span_endtime").attr("class") == "b4") {
                    $("#other_span_endtime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_endtime").attr("class") == "b3") {
                        $("#other_span_endtime").removeClass().addClass("b1")
                    }
                }
                if ($("#other_span_starttime").attr("class") == "b4") {
                    $("#other_span_starttime").removeClass().addClass("b2")
                } else {
                    if ($("#other_span_starttime").attr("class") == "b3") {
                        $("#other_span_starttime").removeClass().addClass("b1")
                    }
                }
            }
            aK = "lishi";
            aV()
        })
    }
    closeTrainStop = function() {
        over_flag = false;
        cm = 0;
        $("#train_stop").hide();
        $("#train_table").html("")
    };
    hideTrainStop = function(cL) {
        over_flag = false;
        if (q) {
            clearTimeout(q)
        }
        q = window.setTimeout(function() {
            if (cm != 1) {
                cm = 0;
                $("#train_stop").hide();
                $("#train_table").html("")
            }
        },
        130)
    };
    checkHover = function(cM, cL) {
        if (getEvent(cM).type == "mouseover") {
            return ! $.contains(cL, getEvent(cM).relatedTarget || getEvent(cM).fromElement) && !((getEvent(cM).relatedTarget || getEvent(cM).fromElement) === cL)
        } else {
            return ! $.contains(cL, getEvent(cM).relatedTarget || getEvent(cM).toElement) && !((getEvent(cM).relatedTarget || getEvent(cM).toElement) === cL)
        }
    };
    getEvent = function(cL) {
        return cL || window.event
    };
    checkHover = function(cM, cL) {
        if (getEvent(cM).type == "mouseover") {
            return ! $.contains(cL, getEvent(cM).relatedTarget || getEvent(cM).fromElement) && !((getEvent(cM).relatedTarget || getEvent(cM).fromElement) === cL)
        } else {
            return ! $.contains(cL, getEvent(cM).relatedTarget || getEvent(cM).toElement) && !((getEvent(cM).relatedTarget || getEvent(cM).toElement) === cL)
        }
    };
    getEvent = function(cL) {
        return cL || window.event
    };
    function bW(cN, cL) {
        for (var cM = 0; cM < cL.length; cM++) {
            if (cL[cM].key == cN) {
                return true
            }
        }
        return false
    }
    function bF(cP) {
        var cU = function(cV) {
            this.value = cV
        };
        var cQ = new Array();
        var cM = new Array();
        var cO = {};
        var cL = {};
        $("#cc_from_station_name_all>ul").html("");
        $("#cc_to_station_name_all>ul").html("");
        var cN;
        var cT;
        var cS;
        for (var cR = 0; cR < cP.length; cR++) {
            cN = cP[cR].queryLeftNewDTO.from_station_name;
            cT = cP[cR].queryLeftNewDTO.to_station_name;
            cS = cP[cR];
            if (!cO[cN]) {
                cQ.push(new cU(cN));
                cO[cN] = true
            }
            if (!cL[cT]) {
                cM.push(new cU(cT));
                cL[cT] = true
            }
        }
        $("#to_station_ul").html($.render.toStationNameTableTemplate(cM));
        $("#from_station_ul").html($.render.stationNameTableTemplate(cQ));
        $("#sear-sel-bd input[name='cc_from_station']").click(function() {
            l(bX, "cc_from_station_" + $(this).val());
            var cV = $("input[name='cc_from_station']");
            var cW = $("input[name='cc_from_station']:checked");
            if ($(this).is(":checked")) {
                if (cV && cW && cW.length == cV.length) {
                    $("#from_station_name_all").removeClass().addClass("btn-all")
                } else {
                    $("#from_station_name_all").removeClass().addClass("btn-all btn-all-sel")
                }
            } else {
                if (cV && cW && cW.length == 0) {
                    $("#from_station_name_all").removeClass().addClass("btn-all")
                } else {
                    $("#from_station_name_all").removeClass().addClass("btn-all btn-all-sel")
                }
            }
            aV()
        });
        $("#sear-sel-bd input[name='cc_to_station']").click(function() {
            l(bI, "cc_to_station_" + $(this).val());
            var cV = $("input[name='cc_to_station']");
            var cW = $("input[name='cc_to_station']:checked");
            if ($(this).is(":checked")) {
                if (cV && cW && cW.length == cV.length) {
                    $("#to_station_name_all").removeClass().addClass("btn-all")
                } else {
                    $("#to_station_name_all").removeClass().addClass("btn-all btn-all-sel")
                }
            } else {
                if (cV && cW && cW.length == 0) {
                    $("#to_station_name_all").removeClass().addClass("btn-all")
                } else {
                    $("#to_station_name_all").removeClass().addClass("btn-all btn-all-sel")
                }
            }
            aV()
        })
    }
    submitOrderRequest = function(cM, cL) {
        $.ajax({
            type: "post",
            url: ctx + "login/checkUser",
            data: {},
            beforeSend: function(cN) {
                cN.setRequestHeader("If-Modified-Since", "0");
                cN.setRequestHeader("Cache-Control", "no-cache")
            },
            success: function(cN) {
                var cQ;
                checkusermdId = cN.attributes;
                if (cN.data.flag) {
                    if (train_tour_flag == "fc") {
                        cQ = $("#back_train_date").val()
                    } else {
                        cQ = $("#train_date").val()
                    }
                    if (B == "0X00") {
                        var cP = false;
                        for (i = (studentComPerArr.length - 1); i >= 0; i = i - 2) {
                            if (G(studentComPerArr[i - 1]) <= G(cQ) && G(studentComPerArr[i]) >= G(cQ)) {
                                cP = true;
                                break
                            }
                        }
                        if (!cP) {
                            b("学生票的乘车时间为每年的暑假6月1日至9月30日、寒假12月1日至3月31日，目前不办理学生票业务。");
                            return
                        }
                    }
                    var cO = $("#fromStation").val();
                    if (cO && cO == "XJA") {
                        dhtmlx.alert({
                            title: "温馨提示",
                            ok: "确定",
                            text: "香港西九龙站乘车前需办理换取纸质车票、实名制验证、安全检查和出入境手续，请您预留足够时间，合理规划行程。",
                            type: "alert-warn",
                            callback: function() {
                                aa(cM, cL)
                            }
                        })
                    } else {
                        aa(cM, cL)
                    }
                } else {
                    $(".mask").fadeIn();
                    $(".login-box .login-hd-code").addClass("active").siblings().removeClass("active");
                    $(".login-box .login-code").show().siblings().hide();
                    $(".login-box").slide({
                        titCell: ".login-hd li",
                        mainCell: ".login-bd",
                        titOnClassName: "active",
                        trigger: "click",
                    });
                    $(".modal-login").css("top", ($(window).height() - $(".modal-login").height()) / 2 + $(window).scrollTop() + "px").css("left", ($(window).width() - $(".modal-login").width()) / 2 + $(window).scrollLeft() + "px").show();
                    $.popup_initLogin(true);
                    $(".modal-login").fadeIn();
                    $.pop_secretStr = cM;
                    $.pop_start_time = cL
                }
            }
        })
    };
    function aa(cY, cR) {
        var cL = "";
        if ($("#dc").is(":checked")) {
            cL = "dc"
        } else {
            cL = "wc"
        }
        if (train_tour_flag == "fc") {
            cL = "fc";
            var cO = cR.split(":");
            var cN = $("#back_train_date").val() + "-" + cO[0] + "-" + cO[1] + "-00";
            try {
                if (roundReferTime) {
                    if (G(roundReferTime) >= G(cN)) {
                        b("您预订的往程车票到站时间为" + G(roundReferTime).format("yyyy年MM月dd日 hh时mm分") + "，返回日期不能早于此时间");
                        return
                    }
                }
            } catch(cT) {}
        }
        if (train_tour_flag == "gc") {
            cL = "gc"
        }
        if ("undefined" == typeof(submitForm)) {
            var cP = "secretStr=" + cY + "&train_date=" + $("#train_date").val() + "&back_train_date=" + $("#back_train_date").val() + "&tour_flag=" + cL + "&purpose_codes=" + cF() + "&query_from_station_name=" + $("#fromStationText").val() + "&query_to_station_name=" + $("#toStationText").val() + "&" + cW
        } else {
            var cM = submitForm();
            var cX = cM.split(":::");
            var cS = cX[0].split(",-,")[0];
            var cV = cX[0].split(",-,")[1];
            var cQ = cX[1].split(",-,")[0];
            var cU = cX[1].split(",-,")[1];
            var cP = escape(cS) + "=" + escape(cV) + "&" + cQ + "=" + cU + "&secretStr=" + cY + "&train_date=" + $("#train_date").val() + "&back_train_date=" + $("#back_train_date").val() + "&tour_flag=" + cL + "&purpose_codes=" + cF() + "&query_from_station_name=" + $("#fromStationText").val() + "&query_to_station_name=" + $("#toStationText").val() + "&" + cW
        }
        var cW = checkusermdId != undefined ? "&_json_att=" + encodeURIComponent(checkusermdId) : "";
        $.ajax({
            type: "post",
            url: ctx + "leftTicket/submitOrderRequest",
            data: cP,
            async: false,
            success: function(cZ) {
                if (cZ.status) {
                    if (cZ.data == "Y") {
                        dhtmlx.alert({
                            title: "温馨提示",
                            ok: "确定",
                            text: "您选择的列车距开车时间很近了，请确保有足够的时间抵达车站，并办理安全检查、实名制验证及检票等手续，以免耽误您的旅行。",
                            type: "alert-warn",
                            callback: function() {
                                bd(cL, train_tour_flag)
                            }
                        })
                    } else {
                        bd(cL, train_tour_flag)
                    }
                }
            }
        })
    }
    function bd(cM, cL) {
        if (cL != null) {
            if (cL == "fc") {
                otsRedirect("post", ctx + "confirmPassenger/initFc", {});
                return
            }
            if (cL == "gc") {
                otsRedirect("post", ctx + "confirmPassenger/initGc", {});
                return
            }
        }
        if (cM == "dc") {
            otsRedirect("post", ctx + "confirmPassenger/initDc", {});
            return
        } else {
            otsRedirect("post", ctx + "confirmPassenger/initWc", {})
        }
    }
    var cG = $("#fromStation").val();
    var bw = $("#toStation").val();
    var cj = $.trim($("#train_date").val());
    bp = cG + bw + cj;
    $("#add-train").click(function() {
        if ($("#fromStationText").val() == "简拼/全拼/汉字") {
            dhtmlx.alert({
                title: "输入车次",
                ok: "确定",
                text: "请填写出发地！",
                type: "alert-error"
            });
            return
        }
        if ($("#toStationText").val() == "简拼/全拼/汉字") {
            dhtmlx.alert({
                title: "输入车次",
                ok: "确定",
                text: "请填写目的地！",
                type: "alert-error"
            });
            return
        }
        var cO = $('#prior_train span[name="prior_train-span"]').length;
        var cP = $.trim($("#inp-train").val()).toUpperCase();
        if (cP.length == 0 || cP == "请输入") {
            dhtmlx.alert({
                title: "输入车次",
                ok: "确定",
                text: "请输入车次",
                type: "alert-error",
                callback: function() {
                    $("#inp-train").val("");
                    $("#inp-train").focus()
                }
            })
        } else {
            if (cO < 6) {
                var cM = /^[a-zA-Z0-9]+$/;
                var cN = /^[0-9]+$/;
                if (!cM.test(cP)) {
                    dhtmlx.alert({
                        title: "输入车次",
                        ok: "确定",
                        text: "车次格式输入错误！",
                        type: "alert-error",
                        callback: function() {
                            ccInputSelected = true;
                            $("#inp-train").select()
                        }
                    })
                } else {
                    if (cN.test(cP) && cP.length > 4) {
                        dhtmlx.alert({
                            title: "输入车次",
                            ok: "确定",
                            text: "车次格式输入错误！",
                            type: "alert-error",
                            callback: function() {
                                ccInputSelected = true;
                                $("#inp-train").select()
                            }
                        })
                    } else {
                        if (cP.length < 2) {
                            dhtmlx.alert({
                                title: "输入车次",
                                ok: "确定",
                                text: "车次格式输入错误！",
                                type: "alert-error",
                                callback: function() {
                                    ccInputSelected = true;
                                    $("#inp-train").select()
                                }
                            })
                        } else {
                            if ($.inArray(cP, ccSelected) < 0) {
                                var cL = "<span name='prior_train-span' class='sel-box w80'>" + cP + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + cP + "\",4)'></a></span>";
                                $("#prior_train").append(cL);
                                ccSelected.push(cP);
                                $("#inp-train").val("")
                            } else {
                                dhtmlx.alert({
                                    title: "输入车次",
                                    ok: "确定",
                                    text: "此车次已经添加过！",
                                    type: "alert-error",
                                    callback: function() {
                                        ccInputSelected = true;
                                        $("#inp-train").select()
                                    }
                                })
                            }
                        }
                    }
                }
            } else {
                dhtmlx.alert({
                    title: "输入车次",
                    ok: "确定",
                    text: "最多添加5个优先车次",
                    type: "alert-error"
                });
                $("#inp-train").val("")
            }
        }
    });
    function cF() {
        if ($("#sf2").is(":checked")) {
            return "0X00"
        } else {
            return "ADULT"
        }
    }
    $("#yxtrain_close").click(function(cL) {
        $("#yxtraindiv").hide()
    });
    $("#yxtrain_a_close").click(function(cL) {
        $("#yxtraininput").val("");
        $("#yxtraininput").trigger("keyup")
    });
    $("#passenger_a_close").click(function(cL) {
        $("#searchPassenger").val("");
        $("#searchPassenger").trigger("keyup")
    });
    $("#yxtraininput").bind("keyup",
    function() {
        var cM = $(this).val().toUpperCase();
        var cL = $("#yxtrain_code").height();
        if (y(cM, 0)) {
            cK(1)
        } else {
            cK(3)
        }
        $("#yxtrain_code").css("height", cL)
    });
    function cK(cL) {
        $("#yxtrain_loading").hide();
        $("#yxtrain_code").hide();
        $("#yxTrain_page").hide();
        $("#yxtrain_empty").hide();
        if (1 == cL) {
            $("#yxtrain_code").show();
            $("#yxTrain_page").show()
        } else {
            if (2 == cL) {
                $("#yxtrain_loading").show()
            } else {
                if (3 == cL) {
                    $("#yxtrain_empty").show()
                }
            }
        }
    }
    function y(cZ, cL) {
        cZ = cZ.toUpperCase();
        var cV = [];
        var c0 = $("#prior_train span:gt(1)");
        if (c0 && c0.length > 0) {
            for (var cO = 0; cO < c0.length; cO++) {
                cV.push(c0[cO].innerText)
            }
        }
        var cY = [];
        var cU = [];
        if (trainListForIE && trainListForIE.length > 0) {
            for (var cM = 0; cM < trainListForIE.length; cM++) {
                cY.push(trainListForIE[cM]);
                cU.push(trainListForIE[cM])
            }
        }
        if (cZ) {
            for (var cO = 0; cO < cU.length; cO++) {
                var cT = cU[cO].substring(0, cU[cO].indexOf("("));
                if (cT.indexOf(cZ) <= -1) {
                    cY.splice($.inArray(cU[cO], cY), 1)
                }
            }
        }
        if (cY && cY.length > 0) {
            var cQ = "";
            for (var cO = 0; cO < cY.length; cO++) {
                var cT = cY[cO];
                var cP = cT.indexOf("(") > -1 ? cT.substring(0, cT.indexOf("(")) : cT;
                var cW = cO >= yxTrainPageSize * (cL) && cO < yxTrainPageSize * (cL + 1);
                if (cW) {
                    if (cP.indexOf(cZ) > -1) {
                        var cS = cT.indexOf(cZ);
                        var cR = cT.substring(0, cS);
                        var cX = cT.substring(cS + cZ.length, cT.indexOf("("));
                        var cN = cT.substring(cT.indexOf("("));
                        if (cV && cV.length > 0 && $.inArray(cP, cV) > -1) {
                            cQ += '<li style="width: 140px;" traincode=' + cP + ' name="yxtrainli" class="cur"><span style="font-size:15px;">' + cR + '<span style="color:red;">' + cZ + "</span>" + cX + "</span>" + cN + "</li>"
                        } else {
                            cQ += '<li style="width: 140px;" traincode=' + cP + ' name="yxtrainli"><span style="font-size:15px;">' + cR + '<span style="color:red;">' + cZ + "</span>" + cX + "</span>" + cN + "</li>"
                        }
                    }
                }
            }
            $("#yxtrain_code").html(cQ)
        } else {
            return false
        }
        if (cY.length > 0) {
            I(cL, cY.length)
        }
        $('li[name="yxtrainli"]').click(function() {
            if ($(this).attr("class") == "cur") {
                var c3 = $('span[name="prior_train-span"]');
                for (var c1 = 0; c1 < c3.length; c1++) {
                    var c2 = $(c3[c1]).html();
                    if (c2.indexOf($(this).attr("traincode")) > -1) {
                        $(c3[c1]).children().click()
                    }
                }
                $(this).removeClass()
            } else {
                $("#inp-train").val($(this).attr("traincode"));
                var c4 = $('#prior_train span[name="prior_train-span"]').length;
                $("#add-train").click();
                if (c4 < 6) {
                    $(this).attr("class", "cur");
                    $.chooseAutoSubmit()
                }
            }
        });
        return true
    }
    function I(cL, cM) {
        var cN = Math.ceil(cM / yxTrainPageSize);
        $("#yxTrain_page").html(aR(cL, cN)).show()
    }
    function aR(cT, cO) {
        var cP = "";
        cP += (cT == 0) ? "": '<a href="javascript:void(0);" onclick="$.click_YX_page(' + (cT - 1) + ')" class="prev">上一页</a>';
        var cU = cT + 1;
        var cQ = cO;
        var cR = 2;
        var cS = 5;
        var cL = (cU - cR) > 0 ? (cU + cR > cQ ? cQ - cS + 1 : cU - cR) : 1;
        var cM = cL + cS > cQ ? cQ + 1 : cL + cS;
        if (cQ < cS) {
            for (var cN = 1; cN < cQ + 1; cN++) {
                if (cU == cN) {
                    cP += '<a href="javascript:void(0);" onclick="$.click_YX_page(' + (cN - 1) + ')" class="on">' + (cN) + "</a>"
                } else {
                    cP += '<a href="javascript:void(0);" onclick="$.click_YX_page(' + (cN - 1) + ')">' + (cN) + "</a>"
                }
            }
        } else {
            for (var cN = cL; cN < cM; cN++) {
                if (cU == cN) {
                    cP += '<a href="javascript:void(0);" onclick="$.click_YX_page(' + (cN - 1) + ')" class="on">' + (cN) + "</a>"
                } else {
                    cP += '<a href="javascript:void(0);" onclick="$.click_YX_page(' + (cN - 1) + ')">' + (cN) + "</a>"
                }
            }
        }
        cP += (cT == cO - 1) ? "": '<a href="javascript:void(0);" onclick="$.click_YX_page(' + (cT + 1) + ')" class="next">下一页</a>';
        return cP
    }
    function bo(cT, cO) {
        if (cO == 0) {
            return ""
        }
        var cP = "";
        cP += (cT == 0) ? "": '<a href="javascript:void(0);" onclick="$.click_passenger_page(' + (cT - 1) + ')" class="prev">上一页</a>';
        var cU = cT + 1;
        var cQ = cO;
        var cR = 2;
        var cS = 5;
        var cL = (cU - cR) > 0 ? (cU + cR > cQ ? cQ - cS + 1 : cU - cR) : 1;
        var cM = cL + cS > cQ ? cQ + 1 : cL + cS;
        if (cQ < cS) {
            for (var cN = 1; cN < cQ + 1; cN++) {
                if (cU == cN) {
                    cP += '<a href="javascript:void(0);" onclick="$.click_passenger_page(' + (cN - 1) + ')" class="on">' + (cN) + "</a>"
                } else {
                    cP += '<a href="javascript:void(0);" onclick="$.click_passenger_page(' + (cN - 1) + ')">' + (cN) + "</a>"
                }
            }
        } else {
            for (var cN = cL; cN < cM; cN++) {
                if (cU == cN) {
                    cP += '<a href="javascript:void(0);" onclick="$.click_passenger_page(' + (cN - 1) + ')" class="on">' + (cN) + "</a>"
                } else {
                    cP += '<a href="javascript:void(0);" onclick="$.click_passenger_page(' + (cN - 1) + ')">' + (cN) + "</a>"
                }
            }
        }
        cP += (cT == cO - 1) ? "": '<a href="javascript:void(0);" onclick="$.click_passenger_page(' + (cT + 1) + ')" class="next">下一页</a>';
        return cP
    }
    function cF() {
        if ($("#sf2").is(":checked")) {
            return "0X00"
        } else {
            return "ADULT"
        }
    }
    jQuery.extend({
        todo_submitOrderRe: function(cM, cL) {
            aa(cM, cL)
        },
        chooseAutoSubmit: function() {
            if (!$("#autoSubmit").is(":disabled")) {
                if (!$("#autoSubmit").is(":checked")) {
                    $("#autoSubmit").click()
                }
            }
        },
        init_ul4li: function() {
            var cL = [];
            var cN = 0;
            cL[cN++] = '<li><input name="cc_type" value="G" type="checkbox" class="check" /><label for="">GC-高铁/城际</label></li>';
            cL[cN++] = '<li><input name="cc_type" value="D" type="checkbox" class="check" /><label for="">D-动车</label></li>';
            cL[cN++] = '<li><input name="cc_type" value="Z" type="checkbox" class="check" /><label for="">Z-直达</label></li>';
            cL[cN++] = '<li><input name="cc_type" value="T" type="checkbox" class="check" /><label for="">T-特快</label></li>';
            cL[cN++] = '<li><input name="cc_type" value="K" type="checkbox" class="check" /><label for="">K-快速</label></li>';
            cL[cN++] = '<li><input name="cc_type" value="QT" type="checkbox" class="check" /><label for="">其他</label></li>';
            $("#_ul_station_train_code").html(cL.join(""));
            if (train_tour_flag == "gc" && "Y" == isDwTicketResign) {
                var cP = $("#_ul_station_train_code li");
                for (var cM = 2,
                cO = cP.length; cM < cO; cM++) {
                    cP.eq(cM).find("input").attr("disabled", "disabled");
                    cP.eq(cM).find("label").attr("for", "").attr("style", "color: rgb(153, 153, 153)")
                }
            }
            $("#startendtime").html('<span class="b1" id="s_time">出发时间</span><br /><span class="b2" id="r_time">到达时间</span>');
            $("#floatstartendtime").html('<span class="b1" id="other_span_starttime">出发时间</span><br /><span class="b2" id="other_span_endtime">到达时间</span>')
        },
        parseDateFormat: function(cP) {
            var cL = "";
            var cM = cP.getFullYear();
            var cO = cP.getMonth() + 1;
            var cN = cP.getDate();
            if (cO < 10) {
                cO = "0" + cO
            }
            if (cN < 10) {
                cN = "0" + cN
            }
            cL = cM + "-" + cO + "-" + cN;
            return cL
        },
        renderPassenger: function(c3) {
            if (!c3) {
                c3 = 0
            }
            if (passengerAll) {
                var cP = $("#searchPassenger").val();
                var cL = [];
                if (cP != "" && cP != "输入乘客姓名") {
                    var c1 = passengerAll.length;
                    for (var cY = 0; cY < c1; cY++) {
                        var cX = passengerAll[cY];
                        if (cX.passenger_name.indexOf(cP) > -1 || (cX.first_letter && cX.first_letter.toUpperCase().indexOf(cP.toUpperCase()) > -1)) {
                            cL.push(cX)
                        }
                    }
                } else {
                    cL = passengerAll.slice(passengerPageSize * (c3), Math.min(passengerPageSize * (c3 + 1), passengerAll.length))
                }
                var cW = cL.length;
                var cU = [];
                var cQ = 0;
                for (var cY = 0; cY < cW; cY++) {
                    var cX = cL[cY];
                    var c2 = cX.passenger_type_name;
                    if (!c2) {
                        c2 = ""
                    }
                    var cO = "";
                    var cM = "";
                    if ($("#sf2").is(":checked")) {
                        if (cX.passenger_type != "3") {
                            cO = " disabled='true' ";
                            cM = " class='color999' "
                        }
                    }
                    var cT = cX.total_times;
                    if (cX.passenger_id_type_code == "2") {
                        cO = " disabled='true' ";
                        cM = " class='color999' title='请修改身份信息' "
                    } else {
                        if (cX.passenger_id_type_code == "1") {
                            if (!isCanGP("1", cT)) {
                                cO = " disabled='true' ";
                                cM = " class='color999' title='请修改身份信息' "
                            }
                        } else {
                            if (!isCanGP("B", cT)) {
                                cO = " disabled='true' ";
                                cM = " class='color999' title='请修改身份信息' "
                            }
                            if (!isCanGP("H", cT)) {
                                cO = " disabled='true' ";
                                cM = " class='color999' title='请修改身份信息' "
                            }
                        }
                    }
                    var cV = c2 == "成人" ? cX.passenger_name: cX.passenger_name + "(" + c2 + ")";
                    cV = cV.substring(0, 9);
                    if (cP != "" && cP != "输入乘客姓名") {
                        if (cX.passenger_name.indexOf(cP) > -1 || (cX.first_letter && cX.first_letter.toUpperCase().indexOf(cP.toUpperCase()) > -1)) {
                            cQ++;
                            if ($.pHasInSelected(cX)) {
                                if (cM) {
                                    var cS = cM.indexOf("'");
                                    cM = cM.substring(0, cS + 1) + "cur " + cM.substring(cS + 1)
                                } else {
                                    cM = "class='cur'"
                                }
                            }
                            cU[cY] = "<li style='width:110px' " + cM + " p_value='" + cX.passenger_name + "(" + c2 + ")(" + cX.passenger_id_no + ")' name='" + cX.passenger_type + "' codeType='" + cX.passenger_id_type_code + "' flag='" + cX.total_times + "'>" + cV + "</li>"
                        }
                    } else {
                        cQ++;
                        if ($.pHasInSelected(cX)) {
                            if (cM) {
                                var cS = cM.indexOf("'");
                                cM = cM.substring(0, cS) + "cur " + cM.substring(cS)
                            } else {
                                cM = "class='cur'"
                            }
                        }
                        cU[cY] = "<li style='width:110px' " + cM + " p_value='" + cX.passenger_name + "(" + c2 + ")(" + cX.passenger_id_no + ")'  name='" + cX.passenger_type + "' codeType='" + cX.passenger_id_type_code + "' flag='" + cX.total_times + "'>" + cV + "</li>"
                    }
                }
                var cZ = 100;
                var c0 = 0;
                if (cQ / 3 > 11) {
                    cZ = 310;
                    c0 = 258
                } else {
                    cZ = 100 + parseInt((cQ / 3) * 25);
                    c0 = cZ - 48
                }
                $("#sel-buyer").css("height", cZ);
                $("#pContent").css("height", c0);
                $("#buyer-list").html(cU.join(""));
                var cN = 0;
                if (cP != "" && cP != "输入乘客姓名") {
                    cN = cL.length
                } else {
                    cN = passengerAll.length
                }
                var cR = Math.ceil(cN / passengerPageSize);
                $("#passenger_page").html(bo(c3, cR)).show()
            }
            $("#buyer-list li").click(function() {
                if ($(this).hasClass("color999")) {
                    return
                }
                var c6 = $("#setion_postion span").length;
                var c8 = $(this).attr("p_value");
                if (!$(this).hasClass("cur")) {
                    if (c6 < 6) {
                        var c4 = "";
                        var c5 = true;
                        if (c8.indexOf("成人") > -1 || c8.indexOf("残疾军人、伤残人民警察") > -1) {
                            c4 = "<span name='" + c8 + "' class='sel-box w80'><a href='javascript:' onclick='$.addChildPassenger(\"" + c8 + "\");' style='position:static;background:none;width:auto;' title='您可点击此乘车人添加儿童票。'>" + c8 + "</a><a class='close' href='javascript:' onclick='$.removeSel(this,\"" + c8 + "\",1)'></a></span>";
                            $("#setion_postion").append(c4);
                            $.checkedPasseanger(c8)
                        } else {
                            if (c8.indexOf("学生") > -1) {
                                var c7 = $(this);
                                if ($.checkSeatTypes()) {
                                    c4 = "<span name='" + c8 + "' class='sel-box w80'>" + c8 + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + c8 + "\",1)'></a></span>";
                                    $("#setion_postion").append(c4);
                                    $.checkedPasseanger(c8)
                                } else {
                                    $("#conifrmdialog_student_to_adult_context").html("当前选择的优先席别有不支持学生票的，是否选择购买成人票？");
                                    dhtmlx.createWin({
                                        winId: "confirmChangeStudentToAdult",
                                        closeWinId: ["close_conifrmdialog_student_to_adult", "cancel_dialog_student_to_adult"],
                                        callback: function() {
                                            $(c7).prop("checked", false)
                                        },
                                        okId: "goto_student_to_adult",
                                        okCallBack: function() {
                                            var c9 = c8.replace(/学生/, "成人");
                                            c4 = "<span name='" + c8 + "' class='sel-box w80'>" + c9 + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + c8 + "\",1)'></a></span>";
                                            $("#setion_postion").append(c4);
                                            $.checkedPasseanger(c9)
                                        }
                                    })
                                }
                            } else {
                                if (c8.indexOf("儿童") > -1) {
                                    c4 = "<span name='" + c8 + "' class='sel-box w80' title='如需修改旅客类型，请修改相应常用联系人信息。'>" + c8 + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + c8 + "\",1)'></a></span>";
                                    $("#setion_postion").append(c4);
                                    $.checkedPasseanger(c8)
                                } else {
                                    c4 = "<span name='" + c8 + "' class='sel-box w80'>" + c8 + "<a class='close' href='javascript:' onclick='$.removeSel(this,\"" + c8 + "\",1)'></a></span>";
                                    $("#setion_postion").append(c4);
                                    $.checkedPasseanger(c8)
                                }
                            }
                        }
                        $(this).addClass("cur");
                        $.chooseAutoSubmit()
                    } else {
                        dhtmlx.alert({
                            title: "添加常用联系人",
                            ok: "确定",
                            text: "最多添加5位联系人",
                            type: "alert-error"
                        });
                        $(this).removeClass("cur")
                    }
                } else {
                    $.each($("#setion_postion span"),
                    function(c9, da) {
                        if (c8 == $(da).attr("name")) {
                            $(da).remove();
                            $.removePasseanger(c8);
                            return
                        }
                    });
                    $(this).removeClass("cur")
                }
            })
        },
        reloadPassenger: function() {
            var cL = dhtmlx.modalbox({
                targSrc: '<div><img src="' + ctx + 'resources/images/loading.gif"></img></div>',
                callback: function() {}
            });
            $.ajax({
                type: "post",
                isTakeParam: false,
                cache: false,
                async: false,
                url: ctx + "confirmPassenger/getPassengerDTOs",
                timeout: 10000,
                error: function(cM, cO, cN) {
                    dhtmlx.modalbox.hide(cL)
                },
                success: function(cM) {
                    dhtmlx.modalbox.hide(cL);
                    if (cM.status) {
                        if (cM.data.noLogin == "true") {
                            $(".mask").fadeIn();
                            $(".login-box .login-hd-code").addClass("active").siblings().removeClass("active");
                            $(".login-box .login-code").show().siblings().hide();
                            $(".login-box").slide({
                                titCell: ".login-hd li",
                                mainCell: ".login-bd",
                                titOnClassName: "active",
                                trigger: "click",
                            });
                            $(".modal-login").css("top", ($(window).height() - $(".modal-login").height()) / 2 + $(window).scrollTop() + "px").css("left", ($(window).width() - $(".modal-login").width()) / 2 + $(window).scrollLeft() + "px").show();
                            $.popup_initLogin(true);
                            $(".modal-login").fadeIn()
                        } else {
                            if (cM.data.exMsg != "" && cM.data.exMsg != null && cM.data.exMsg != "null") {
                                b(cM.data.exMsg);
                                return
                            }
                            $("#sel-buyer").show();
                            $("#sel-seat").hide();
                            $("#sel-date").hide();
                            $("#sel-buyer").css("left", $("#sear-sel").position().left + 80);
                            $("#sel-buyer").css("left", $("#sear-sel").position().left + 80);
                            $("#sel-buyer").css("top", $("#sear-sel").position().top + 4 * 28 + 16);
                            passengerAll = cM.data.normal_passengers;
                            if (! (passengerAll && passengerAll.length > 0)) {
                                passengerAll = []
                            }
                            var cP = cM.data.dj_passengers;
                            if (cP && cP.length > 0) {
                                var cO = cP.length;
                                for (var cN = 0; cN < cO; cN++) {
                                    if (!$.checkIsHas(passengerAll, cP[cN])) {
                                        passengerAll.push(cP[cN])
                                    }
                                }
                            }
                            two_isOpenClick = cM.data.two_isOpenClick;
                            other_isOpenClick = cM.data.other_isOpenClick;
                            $.renderPassenger()
                        }
                    }
                }
            })
        },
        checkIsHas: function(cN, cO) {
            var cM = cN.length;
            for (var cL = 0; cL < cM; cL++) {
                if (cN[cL].passenger_name == cO.passenger_name && cN[cL].passenger_id_type_code == cO.passenger_id_type_code && cO.passenger_id_no == cN[cL].passenger_id_no) {
                    return true
                }
            }
            return false
        },
        pHasInSelected: function(cO) {
            var cM = passengerChecked.length;
            if (cM > 0) {
                for (var cL = 0; cL < cM; cL++) {
                    var cN = passengerChecked[cL];
                    if (cN.passenger_name == cO.passenger_name && cN.passenger_id_type_code == cO.passenger_id_type_code && cN.passenger_id_no == cO.passenger_id_no) {
                        return true
                    }
                }
            }
            return false
        },
        showSelectBuyer: function() {
            $("#sel-seat").hide();
            $("#yxtraindiv").hide();
            $("#sel-date").hide();
            if (!passengerAll) {
                $.reloadPassenger()
            } else {
                var cL = $("#buyer-list li");
                for (var cM = 0; cM < cL.length; cM++) {
                    var cO = $(cL[cM]).attr("name");
                    var cN = $(cL[cM]).attr("codeType");
                    var cP = $(cL[cM]).attr("flag");
                    if ($("#sf2").is(":checked")) {
                        if (cO != "3") {
                            $(cL[cM]).addClass("color999")
                        } else {
                            $(cL[cM]).removeClass("color999")
                        }
                    } else {
                        $(cL[cM]).removeClass("color999")
                    }
                    if (cN == "2") {
                        $(cL[cM]).addClass("color999")
                    } else {
                        if (cN == "1") {
                            if (!isCanGP("1", cP)) {
                                $(cL[cM]).addClass("color999")
                            }
                        } else {
                            if (!isCanGP("B", cP)) {
                                $(cL[cM]).addClass("color999")
                            }
                            if (!isCanGP("H", cP)) {
                                $(cL[cM]).addClass("color999")
                            }
                        }
                    }
                }
                $("#sel-buyer").show();
                $("#sel-buyer").css("left", $("#sear-sel").position().left + 80);
                $("#sel-buyer").css("top", $("#sear-sel").position().top + 4 * 28 + 16)
            }
        },
        click_YX_page: function(cM) {
            var cN = $("#yxtraininput").val().toUpperCase();
            var cL = $("#yxtrain_code").height();
            if (y(cN, cM)) {
                cK(1)
            } else {
                cK(3)
            }
            $("#yxtrain_code").css("height", cL)
        },
        click_passenger_page: function(cL) {
            $.renderPassenger(cL)
        },
        hbgetDateDiff: function(cO, cN) {
            var cM = new Date(cO.substring(0, 4) + "/" + cO.substring(5, 7) + "/" + cO.substring(8, 10)).getTime();
            var cL = new Date(cN.substring(0, 4) + "/" + cN.substring(5, 7) + "/" + cN.substring(8, 10)).getTime();
            return Math.abs((cL - cM) / 1000 / 60 / 60 / 24)
        },
        isCanChangeHBDate: function() {
            var cM = $(".cart-tlist li");
            if (cM.length == 0) {
                return true
            }
            var cN = "";
            for (var cL = 0; cL < cM.length; cL++) {
                var cP = $(cM[cL]).attr("hbid").split("#")[0];
                if (cN.indexOf(cP) == -1) {
                    cN += cP
                }
            }
            if (yxTrainChange) {
                if ($("#fromStationText").val() != yxTrainChange.split("#")[0] || $("#toStationText").val() != yxTrainChange.split("#")[1]) {
                    $("#hb_msg").html(hb_date_msg_station);
                    dhtmlx.createWin({
                        winId: "hb_info",
                        closeWinId: ["hb_info_close", "hb_info_cancel"],
                        okId: "hb_info_ok",
                        callback: function() {
                            return
                        },
                        okCallBack: function() {
                            $("#hbClear").click();
                            $("#query_ticket").click()
                        }
                    });
                    return false
                }
            }
            if (cN == "" || cN.indexOf($("#train_date").val()) > -1) {
                return true
            }
            var cO = $.hbgetDateDiff(cN, $("#train_date").val());
            if (cN.length / 10 == 2) {
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: hb_date_msg,
                    type: "alert-error"
                });
                return false
            }
            if (cO != 1) {
                dhtmlx.alert({
                    title: "提示",
                    ok: "确定",
                    text: hb_date_msg_diff,
                    type: "alert-error"
                });
                return false
            }
            return true
        },
        showYxTrain: function() {
            if (!$.isCanChangeHBDate()) {
                return
            }
            $("#yxtrain_code").css("height", "auto");
            $("#yxtrain_code li").removeClass();
            $("#yxtraininput").val("");
            $("#yxtraindiv").css("top", $("#showYxTrainSpan").offset().top + $("#showYxTrainSpan").outerHeight()).css("left", $("#showYxTrainSpan").offset().left).show();
            cK(2);
            var cN = $("#fromStationText").val() + "#" + $("#toStationText").val() + "#" + $("#train_date").val();
            if (trainListForIE.length == 0 || yxTrainChange != cN) {
                B = cF();
                var cP = B == "0X00" ? true: false;
                var cM = train_tour_flag == "fc" ? $.trim($("#back_train_date").val()) : $.trim($("#train_date").val());
                var cL = b5(cM, cP);
                if (!cL) {
                    $("#yxtraindiv").hide();
                    return
                }
                var cO = {
                    "leftTicketDTO.train_date": cM,
                    "leftTicketDTO.from_station": $("#fromStation").val(),
                    "leftTicketDTO.to_station": $("#toStation").val(),
                    purpose_codes: B
                };
                bc();
                $.ajax({
                    type: "get",
                    isTakeParam: false,
                    beforeSend: function(cQ) {
                        cQ.setRequestHeader("If-Modified-Since", "0");
                        cQ.setRequestHeader("Cache-Control", "no-cache")
                    },
                    url: ctx + CLeftTicketUrl,
                    data: cO,
                    timeout: 10000,
                    success: function(cS) {
                        if (cS.status) {
                            if (cS.data == null || cS.data.length == 0) {
                                cK(3);
                                trainListForIE = [];
                                return
                            }
                            if (cS.data.flag == 1) {
                                cS.data = cp(cS.data.result, cS.data.map)
                            }
                            trainListForIE = [];
                            for (var cT = 0; cT < cS.data.length; cT++) {
                                trainListForIE.push(cS.data[cT].queryLeftNewDTO.station_train_code + "(" + cS.data[cT].queryLeftNewDTO.start_time + "--" + cS.data[cT].queryLeftNewDTO.arrive_time + ")")
                            }
                            if (train_tour_flag == "gc" && "Y" == isDwTicketResign) {
                                var cZ = [];
                                for (var cT = 0,
                                c0 = cS.data.length; cT < c0; cT++) {
                                    var cR = cS.data[cT].queryLeftNewDTO;
                                    var cW = cR.station_train_code;
                                    cW = cW.substring(0, 1);
                                    if ("G" == cW || "D" == cW) {
                                        cZ.push(cS.data[cT])
                                    }
                                }
                                cS.data = cZ
                            }
                            if ($("#DW_SHOW_STR")[0]) {
                                $("#DW_SHOW_STR").remove()
                            }
                            if ($("#hainan_limit_msg")[0]) {
                                $("#hainan_limit_msg").remove()
                            }
                            $("#sear-sel").show();
                            $("#sear-result").show();
                            $("#t-list").show();
                            $("#no_filter_ticket_2").hide();
                            $("#no_filter_ticket_6").hide();
                            $("#no_filter_ticket").hide();
                            var cQ = "";
                            var cV = "";
                            if (train_tour_flag != null && train_tour_flag == "fc") {
                                var cY = "<strong>".concat($("#fromStationText").val()).concat(" --> ").concat($("#toStationText").val()).concat("（").concat(aQ($("#back_train_date").val())).concat('）</strong>共计<strong id="trainum">').concat(cS.data.length).concat("</strong>个车次");
                                if (ci(cS.data)) {
                                    cQ = "<p class='ad-gt' id='DW_SHOW_STR' data='1'>高铁动卧 夕发朝至 风雨无阻 省时省钱</p>"
                                } else {
                                    if (hainan_limit_msg && ao(cO, cS.data)) {
                                        cV = "<p class='ad-gt' id='hainan_limit_msg'  style='font-size:13px;background:#fff6f6 left center no-repeat;font-weight:bold'>" + hainan_limit_msg + "</p>"
                                    }
                                }
                                if ($("#auto_query").is(":checked")) {
                                    var cX = "";
                                    for (var cU = 0; cU < 25; cU++) {
                                        cX = cX + "&nbsp;"
                                    }
                                    cY = cY.concat(cX + "<input type='checkbox' class='check' id='filterTic' /><div id='filterTicDiv' style='display:inline'><strong><label for='filterTic' style='cursor: pointer;'>仅查看刷到车次</label></strong></div>")
                                }
                                $("#sear-result>p").html(cY);
                                if ($("#auto_query").is(":checked")) {
                                    $("#filterTic").bind("click", by)
                                }
                            } else {
                                var cY = "<strong>".concat($("#fromStationText").val()).concat(" --> ").concat($("#toStationText").val()).concat("（").concat(aQ($("#train_date").val())).concat('）</strong>共计<strong id="trainum">').concat(cS.data.length).concat("</strong>个车次");
                                if (ci(cS.data)) {
                                    cQ = "<p class='ad-gt' id='DW_SHOW_STR' data='1'>高铁动卧 夕发朝至 风雨无阻 省时省钱</p>"
                                } else {
                                    if (hainan_limit_msg && ao(cO, cS.data)) {
                                        cV = "<p class='ad-gt' id='hainan_limit_msg'  style='font-size:13px;background:#fff6f6 left center no-repeat;font-weight:bold'>" + hainan_limit_msg + "</p>"
                                    }
                                }
                                if ($("#auto_query").is(":checked")) {
                                    var cX = "";
                                    for (var cU = 0; cU < 25; cU++) {
                                        cX = cX + "&nbsp;"
                                    }
                                    cY = cY.concat(cX + "<input type='checkbox' class='check' id='filterTic' /><div id='filterTicDiv' style='display:inline'><strong><label for='filterTic' style='cursor: pointer;'>仅查看刷到车次</label></strong></div>")
                                }
                                $("#sear-result>p").html(cY);
                                if ($("#auto_query").is(":checked")) {
                                    $("#filterTic").bind("click", by)
                                }
                            }
                            if (!$("#DW_SHOW_STR")[0]) {
                                $("#sear-result>p").after(cQ)
                            }
                            if (cV) {
                                $("#sear-result>p").after(cV)
                            }
                            if (dwTranTimeStr) {
                                clearInterval(dwTranTimeStr)
                            }
                            if ($("#DW_SHOW_STR")[0]) {
                                dwTranTimeStr = window.setInterval(function() {
                                    if ($("#DW_SHOW_STR").attr("data") == "1") {
                                        $("#DW_SHOW_STR").attr("data", "2").html("夜行两千公里 最低不足千元")
                                    } else {
                                        $("#DW_SHOW_STR").attr("data", "1").html("高铁动卧 夕发朝至 风雨无阻 省时省钱")
                                    }
                                },
                                1300)
                            }
                            if ($("#hainan_limit_msg")[0]) {
                                hainan_tip = null;
                                hainan_tip = new Marquee({
                                    ID: "hainan_limit_msg",
                                    Direction: "left",
                                    Step: 1,
                                    Width: 0,
                                    Height: 0,
                                    Timer: 30,
                                    DelayTime: 0,
                                    WaitTime: 0,
                                    ScrollStep: 0
                                })
                            }
                            br = cS.data;
                            at();
                            bF(br);
                            o();
                            b1(br);
                            b9();
                            $("#queryLeftTable").html("");
                            $("#trainum").html("");
                            aZ();
                            if (cl.length < 0) {
                                a5 = true;
                                $("#no_filter_ticket").show();
                                $("#no_filter_ticket_msg_1").show();
                                $("#no_filter_ticket_msg_2").hide();
                                $("#trainum").html("0");
                                return
                            } else {
                                a5 = true;
                                $("#trainum").html(cl.length);
                                aN(cl);
                                $.showYxTrainData()
                            }
                            t();
                            yxTrainChange = $("#fromStationText").val() + "#" + $("#toStationText").val() + "#" + $("#train_date").val()
                        } else {
                            if (cS && cS.c_url) {
                                CLeftTicketUrl = cS.c_url;
                                av(cO)
                            }
                        }
                    }
                });
                yxTrainChange = cN
            } else {
                $.showYxTrainData()
            }
            $("#sel-buyer").hide();
            $("#sel-seat").hide();
            $("#sel-date").hide()
        },
        showYxTrainData: function() {
            if (y($("#yxtraininput").val(), 0)) {
                $("#yxtraindiv").css("top", $("#showYxTrainSpan").offset().top + $("#showYxTrainSpan").outerHeight()).css("left", $("#showYxTrainSpan").offset().left).show();
                cK(1);
                $("#yxtraininput").focus()
            } else {
                cK(3)
            }
        },
        getMindateForCal: function() {
            if ($("#sf2").is(":checked")) {
                h = studentMindate
            } else {
                h = otherMindate
            }
            return h
        },
        getMaxdateForCal: function() {
            if ($("#sf2").is(":checked")) {
                H = studentMaxdate
            } else {
                H = otherMaxdate
            }
            return H
        }
    });
    function K() {
        $("#show_all_query_result").click(function() {
            bX = new Array();
            bI = new Array();
            S = new Array();
            $("#train_type_btn_all").removeClass().addClass("btn-all");
            $("#start_time_btn_all").removeClass().addClass("btn-all");
            $("#arrive_time_btn_all").removeClass().addClass("btn-all");
            $("#seat_type_btn_all").removeClass().addClass("btn-all");
            $("#from_station_name_all").removeClass().addClass("btn-all");
            $("#to_station_name_all").removeClass().addClass("btn-all");
            $("#sear-sel-bd input").each(function() {
                if (this.checked) {
                    this.checked = false
                }
            });
            if (aJ) {
                aJ.setComboText("")
            }
            $("#avail_ticket").attr("checked", false);
            aV()
        })
    }
    function aE() {
        var cL = $("#queryPriceTemplate").html().replace("<!--", "").replace("-->", "");
        $.templates({
            priceTableTemplate: cL
        });
        var cL = $("#fromStationNameTemplate").html().replace("<!--", "").replace("-->", "");
        $.templates({
            stationNameTableTemplate: cL
        });
        var cL = $("#toStationNameTemplate").html().replace("<!--", "").replace("-->", "");
        $.templates({
            toStationNameTableTemplate: cL
        });
        var cL = $("#seatTypeTemplate").html().replace("<!--", "").replace("-->", "");
        $.templates({
            seatTypeTemplate: cL
        });
        var cL = $("#stationinfoTemplate").html().replace("<!--", "").replace("-->", "");
        $.templates({
            stationinfoTemplate: cL
        })
    }
    function b1(cM) {
        dhtmlXCombo_defaultOption.prototype._DrawHeaderButton = function() {};
        $("#train_combo_box").hide();
        var cL = [];
        if (!aJ) {
            aJ = new dhtmlXCombo("train_combo_box_div", "cc", 90)
        } else {
            aJ.setComboText("")
        }
        aJ.clearAll();
        $(cM).each(function() {
            cL.push([this.queryLeftNewDTO.station_train_code, this.queryLeftNewDTO.station_train_code])
        });
        aJ.addOption(cL);
        aJ.enableFilteringMode(true);
        aJ.attachEvent("onChange",
        function() {
            if (aJ.getComboText() != "") {
                if ($("#iLcear").is(":hidden")) {
                    $("#iLcear").show()
                }
            }
            aV()
        });
        if (!$("#iLcear")[0]) {
            $(".dhx_combo_box ").append($('<span style="display: none;" class="i-clear dhx_combo_img_iClear" id="iLcear"></span>'));
            $("#iLcear").on("click",
            function() {
                if (aJ) {
                    aJ.setComboText("");
                    $(this).hide()
                }
            })
        }
        $(".dhx_combo_input").on("keyup",
        function() {
            if ($(this).val() == "") {
                $("#iLcear").hide()
            } else {
                if ($("#iLcear").is(":hidden")) {
                    $("#iLcear").show()
                }
            }
        })
    }
    function aC() {
        if (!cw) {
            cw = new dhtmlXWindows();
            cw.enableAutoViewport(true);
            cw.setSkin("dhx_terrace");
            cw.attachViewportTo("winVP");
            cw.setImagePath(ctx + "resources/js/rich/windows/imgs/")
        }
        $("#username").keydown(function() {
            login_errorMsg_hide()
        });
        $("#password").keydown(function() {
            login_errorMsg_hide()
        })
    }
    function bN() {
        cw.window("login").hide();
        cw.window("login").setModal(false)
    }
    function bQ() {
        if (cw.window("login")) {
            cw.window("login").setModal(false);
            cw.window("login").hide()
        }
        bj = cw.createWindow("login", 0, 0, 400, 350);
        var cL, cM;
        if (typeof(TouLocal) != "undefined" && TouLocal.checkZByTargeElement("")) {
            cL = $(window).width() / 2 - 208;
            cM = cC() + ($(window).height() / 2 - 232)
        } else {
            cL = $(window).width() / 2 - 200;
            cM = cC() + ($(window).height() / 2 - 205)
        }
        bj.attachObject("relogin");
        if (if_show_pass_code_login == "Y") {
            bj.setDimension($("#content").width(), $("#content").height() + 10)
        } else {
            bj.setDimension(530, 343);
            cL = $(window).width() / 2 - 250
        }
        $(".dhtmlx_window_active").height($("#content").height());
        $(".dhtmlx_window_active").css({
            left: cL,
            top: cM
        });
        bj.bringToTop();
        cw.window("login").clearIcon();
        cw.window("login").denyResize();
        bj.button("park").hide();
        bj.button("minmax1").hide();
        bj.hideHeader();
        if (if_show_pass_code_login == "Y") {
            if (is_uam_login == "Y") {
                refreshImgUAM("login", "sjrand")
            } else {
                refreshImg("login", "sjrand")
            }
        }
        bj.setModal(true);
        $("#relogin_close").click(function() {
            bA();
            var cN = $(window).scrollTop();
            var cO = $("#float").position().top;
            if (cN > cO + 30) {
                $("#floatTable").show()
            }
            bN()
        });
        if (typeof(touclickHook_leftTicketLogin) === "function") {
            touclickHook_leftTicketLogin()
        }
    }
    function bA() {
        a6();
        $("#username").val("");
        $("#password").val("");
        $("#randCode").val("");
        cq()
    }
    function cC() {
        if ("pageYOffset" in window) {
            return window.pageYOffset
        } else {
            if (document.compatMode == "BackCompat") {
                return document.body.scrollTop
            } else {
                return document.documentElement.scrollTop
            }
        }
    }
    function a6() {
        $("#username").add($("#password")).add($("#randCode")).add($("#randCode2")).removeClass("error")
    }
    function F(cP) {
        var cM = /^(13[0-9])|(14[0-9])|(15[0-9])|(18[0-9])|(17[0-9])|(19[0-9])|(16[0-9])\d{8}$/;
        var cL = /^[A-Za-z]{1}([A-Za-z0-9]|[_]){0,29}$/;
        var cO = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$/i;
        var cN = true;
        a6();
        if ("" == cP || cP == null || cP == uninputmsg || cP == "admin") {
            $("#username").removeClass("inptxt w200").addClass("inptxt w200 error");
            cN = login_messages.userNameEmpty
        } else {
            if (!cL.test(cP) && !cO.test(cP) && !cM.test(cP)) {
                $("#username").removeClass("inptxt w200").addClass("inptxt w200 error");
                cN = login_messages.userNameFormat
            }
        }
        return cN
    }
    function bS(cL) {
        var cM = true;
        a6();
        if ("" == cL || cL == null) {
            $("#password").removeClass("inptxt w200").addClass("inptxt w200 error");
            cM = login_messages.passwordEmpty
        } else {
            if (cL.length < 6) {
                $("#password").removeClass("inptxt w200").addClass("inptxt w200 error");
                cM = login_messages.passwordLength
            }
        }
        return cM
    }
    function ba() {
        var cN = $.trim($("#username").val());
        var cL = $.trim($("#password").val());
        var cM = F(cN);
        return typeof(cM) === "boolean" ? bS(cL) : cM
    }
    function E() {
        var cM = false;
        var cL = false;
        $("#username").on("keyup",
        function() {
            aO = true
        }).blur(function() {
            if (aO) {
                var cN = $.trim($("#username").val());
                cM = F(cN);
                if (if_show_pass_code_login == "Y") {
                    if (typeof(cM) !== "boolean") {
                        showError($("#randCode")[0], cM)
                    } else {
                        if (cM === true) {
                            showError($("#randCode")[0]).hide()
                        }
                    }
                } else {
                    if (typeof(cM) !== "boolean") {
                        login_errorMsg(cM)
                    } else {
                        if (cM === true) {
                            login_errorMsg_hide()
                        }
                    }
                }
            }
        });
        $("#password").blur(function() {
            if (aO) {
                var cN = $.trim($("#password").val());
                if (if_show_pass_code_login == "Y") {
                    if (cM === true && typeof(cL = bS(cN)) !== "boolean") {
                        showError($("#randCode")[0], cL)
                    } else {
                        if (cM === true && cL === true) {
                            showError($("#randCode")[0]).hide()
                        }
                    }
                } else {
                    if (cM === true && typeof(cL = bS(cN)) !== "boolean") {
                        login_errorMsg(cL)
                    } else {
                        if (cM === true && cL === true) {
                            login_errorMsg_hide()
                        }
                    }
                }
            }
        })
    }
    function cx(cL) {
        $("#password").val("");
        $("#randCode").val("");
        if (cL != null) {
            if (cL == "登录名不存在。") {
                aO = false;
                $("#username").add($("#password")).add($("#randCode")).add($("#randCode2")).removeClass("error");
                $("#username").removeClass("inptxt w200").addClass("inptxt w200 error");
                $("#username").focus()
            } else {
                if (cL.indexOf("密码输入错误。") != -1) {
                    $("#username").add($("#password")).add($("#randCode")).add($("#randCode2")).removeClass("error");
                    $("#password").removeClass("inptxt w200").addClass("inptxt w200 error");
                    $("#password").focus()
                }
            }
            if (if_show_pass_code_login == "Y") {
                showError($("#randCode")[0], cL)
            } else {
                login_errorMsg(cL)
            }
        }
    }
    function aj(cM, cL) {
        $("#loginSubAsyn").unbind("click");
        $("#loginSubAsyn").click(function() {
            var cN = ba();
            if (is_uam_login == "Y") {
                if (if_show_pass_code_login == "Y" && !verifyRandCodeUAM($("#randCode")[0], cN)) {
                    return
                }
                if (if_show_pass_code_login == "N" && typeof(cN) !== "boolean") {
                    login_errorMsg(cN);
                    return
                }
                $.ajax({
                    url: passport_login,
                    data: {
                        username: $("#username").val(),
                        password: $("#password").val(),
                        appid: passport_appId
                    },
                    dataType: "json",
                    type: "POST",
                    xhrFields: {
                        withCredentials: true
                    },
                    success: function(cO) {
                        if (cO.result_code == 0) {
                            $.ajax({
                                type: "POST",
                                url: passport_authuam,
                                async: false,
                                data: {
                                    appid: passport_appId
                                },
                                dataType: "jsonp",
                                jsonp: "callback",
                                success: function(cP) {
                                    if (cP.result_code == 0) {
                                        var cQ = cP.newapptk || cP.apptk;
                                        $.ajax({
                                            type: "POST",
                                            async: false,
                                            url: ctx + passport_authclient,
                                            data: {
                                                tk: cQ
                                            },
                                            datatype: "json",
                                            success: function(cR) {
                                                if (cR.result_code == 0) {
                                                    bN();
                                                    loginAsyn(cR.username);
                                                    aa(cM, cL)
                                                }
                                            },
                                            error: function() {}
                                        })
                                    }
                                },
                                error: function() {}
                            })
                        } else {
                            if (if_show_pass_code_login == "Y") {
                                showSuc($("#randCode")[0]).hide()
                            } else {
                                login_errorMsg_hide()
                            }
                            if (if_show_pass_code_login == "Y") {
                                refreshImgUAM("login", "sjrand")
                            }
                            cx(cO.result_message)
                        }
                    }
                })
            } else {
                if (if_show_pass_code_login == "Y" && !verifyRandCode($("#randCode")[0], cN)) {
                    return
                }
                if (if_show_pass_code_login == "N" && typeof(cN) !== "boolean") {
                    login_errorMsg(cN);
                    return
                }
                $("#loginForm").ajaxSubmit({
                    url: ctx + "login/loginUserAsyn?random=" + new Date().getTime(),
                    type: "post",
                    dataType: "json",
                    async: false,
                    success: function(cO) {
                        if (cO.data.status) {
                            if (cO.data.username != null) {
                                bN();
                                loginAsyn(cO.data.username);
                                if (cO.data.otherMsg != "") {
                                    dhtmlx.alert({
                                        title: messages["message.error"],
                                        ok: messages["button.ok"],
                                        text: cO.data.otherMsg,
                                        type: "alert-error",
                                        callback: function() {
                                            if ("Y" == cO.data.notifysession) {
                                                dhtmlx.createWin({
                                                    winId: "notifysession",
                                                    closeWinId: ["close_notifysession"],
                                                    okId: "goto_notifysession",
                                                    okCallBack: function() {
                                                        aa(cM, cL)
                                                    }
                                                })
                                            } else {
                                                aa(cM, cL)
                                            }
                                        }
                                    })
                                } else {
                                    if ("Y" == cO.data.notifysession) {
                                        dhtmlx.createWin({
                                            winId: "notifysession",
                                            closeWinId: ["close_notifysession"],
                                            okId: "goto_notifysession",
                                            okCallBack: function() {
                                                aa(cM, cL)
                                            }
                                        })
                                    } else {
                                        aa(cM, cL)
                                    }
                                }
                            }
                        } else {
                            if (cO.data.uamflag == "1") {
                                location.reload(true)
                            }
                            if (if_show_pass_code_login == "Y") {
                                showSuc($("#randCode")[0]).hide()
                            } else {
                                login_errorMsg_hide()
                            }
                            if (if_show_pass_code_login == "Y") {
                                refreshImg("login", "sjrand")
                            }
                            cx(cO.data.loginFail)
                        }
                    }
                })
            }
        })
    }
    function ah() {
        var cL = false;
        $("#loginSubAsyn").unbind("click");
        $("#loginSubAsyn").click(function() {
            if (!cL) {
                var cM = ba();
                if (is_uam_login == "Y") {
                    if (if_show_pass_code_login == "Y" && !verifyRandCodeUAM($("#randCode")[0], cM)) {
                        cL = false;
                        return
                    }
                    cL = true;
                    $("#loginForm").ajaxSubmit({
                        url: passport_login,
                        data: {
                            username: $("#username").val(),
                            password: $("#password").val(),
                            appid: passport_appId
                        },
                        dataType: "json",
                        type: "POST",
                        xhrFields: {
                            withCredentials: true
                        },
                        success: function(cN) {
                            if (cN.result_code == 0) {
                                $.ajax({
                                    type: "POST",
                                    url: passport_authuam,
                                    async: false,
                                    data: {
                                        appid: passport_appId
                                    },
                                    dataType: "jsonp",
                                    jsonp: "callback",
                                    success: function(cO) {
                                        if (cO.result_code == 0) {
                                            var cP = cO.newapptk || cO.apptk;
                                            $.ajax({
                                                type: "POST",
                                                async: false,
                                                url: ctx + passport_authclient,
                                                data: {
                                                    tk: cP
                                                },
                                                datatype: "json",
                                                success: function(cQ) {
                                                    if (cQ.result_code == 0) {
                                                        bN();
                                                        loginAsyn(cQ.username)
                                                    }
                                                },
                                                error: function() {}
                                            })
                                        }
                                    },
                                    error: function() {}
                                })
                            } else {
                                $("#i-ok").hide();
                                if (if_show_pass_code_login == "Y") {
                                    refreshImgUAM("login", "sjrand")
                                }
                                cx(cN.result_message)
                            }
                        },
                        complete: function() {
                            cL = false
                        }
                    })
                } else {
                    if (if_show_pass_code_login == "Y" && !verifyRandCode($("#randCode")[0], cM)) {
                        cL = false;
                        return
                    }
                    cL = true;
                    $("#loginForm").ajaxSubmit({
                        url: ctx + "login/loginUserAsyn?random=" + new Date().getTime(),
                        type: "post",
                        dataType: "json",
                        async: false,
                        success: function(cN) {
                            if (cN.data.status) {
                                if (cN.data.otherMsg != "") {
                                    dhtmlx.alert({
                                        title: messages["message.error"],
                                        ok: messages["button.ok"],
                                        text: cN.data.otherMsg,
                                        type: "alert-error",
                                        callback: function() {
                                            if (cN.data.username != null) {
                                                bN();
                                                loginAsyn(cN.data.username)
                                            }
                                        }
                                    })
                                } else {
                                    if (cN.data.username != null) {
                                        bN();
                                        loginAsyn(cN.data.username)
                                    }
                                }
                            } else {
                                if (cN.data.uamflag == "1") {
                                    location.reload(true)
                                }
                                $("#i-ok").hide();
                                if (if_show_pass_code_login == "Y") {
                                    refreshImg("login", "sjrand")
                                }
                                cx(cN.data.loginFail)
                            }
                        },
                        complete: function() {
                            cL = false
                        }
                    })
                }
            }
        })
    }
    function be() {
        window.sucessCallback = function() {
            bT = $("#randCode2").val();
            $("#back_edit").trigger("click");
            var cL = "99999GGGGG";
            var cN = "##CCT##PPT##CPT##PXT##SBT##PBD##JOD##HPD##SHD##QTP##TSP##TJP##";
            var cM = "##CBP##DIP##JGK##ZEK##UUH##NKH##ESH##OHH##AOH##";
            if (isAsync == ticket_submit_order.request_flag.isAsync) {
                if (P.queryLeftNewDTO.train_no.indexOf(cL) > -1 && cN.indexOf(P.queryLeftNewDTO.from_station_telecode) > -1 && cM.indexOf(P.queryLeftNewDTO.to_station_telecode) > -1) {
                    dhtmlx.createWin({
                        winId: "confirmG1234",
                        closeWinId: ["close_conifrmdialog_G1234", "cancel_dialog_G1234"],
                        okId: "goto_integration_G1234",
                        okCallBack: function() {
                            r()
                        },
                        callback: function() {
                            return
                        }
                    })
                } else {
                    r()
                }
            } else {
                if (P.queryLeftNewDTO.train_no.indexOf(cL) > -1 && cN.indexOf(P.queryLeftNewDTO.from_station_telecode) > -1 && cM.indexOf(P.queryLeftNewDTO.to_station_telecode) > -1) {
                    dhtmlx.createWin({
                        winId: "confirmG1234",
                        closeWinId: ["close_conifrmdialog_G1234", "cancel_dialog_G1234"],
                        okId: "goto_integration_G1234",
                        okCallBack: function() {
                            cJ()
                        },
                        callback: function() {
                            return
                        }
                    })
                } else {
                    cJ()
                }
            }
            return
        }
    }
    function cq() {
        $("#username").css("color", "#333");
        $("#password").css("color", "#333");
        $("#randCode").css("color", "#333");
        if ($("#username").val() == "" || $("#username").val() == uninputmsg || $("#username").val() == null || $("#username").val() == "admin") {
            $("#username").css("color", "#999");
            $("#username").val(uninputmsg);
            $("#password").val("")
        }
        $("#username").focus(function() {
            var cL = $("#username").val();
            if (cL == uninputmsg) {
                $("#username").css("color", "#333");
                $("#username").val("");
                $("#password").val("")
            }
        }).blur(function() {
            var cL = $("#username").val();
            if (cL == "") {
                $("#username").css("color", "#999");
                $("#username").val(uninputmsg)
            }
        })
    }
    function ar() {
        $("#forget_my_password_id").on("click",
        function(cL) {
            otsRedirect("post", ctx + "forgetPassword/initforgetMyPassword")
        })
    }
    function bc() {
        var cL = 1;
        var cR;
        var cW;
        var cN;
        var cQ = true;
        var cP = true;
        var cU = true;
        var cY;
        var cM;
        var cV = false;
        var cS = false;
        var cX = false;
        cN = dataNumber;
        var cT;
        if (train_tour_flag != null && train_tour_flag != "" && train_tour_flag == "fc") {
            cT = jQuery.inArray($("#back_train_date").val().substring(5, 10), change_dates_arr)
        } else {
            cT = jQuery.inArray($("#train_date").val().substring(5, 10), change_dates_arr)
        }
        if (cT != "-1") {
            cT = cT + 1;
            cY = firstShow;
            cM = endShow;
            if (parseInt(cT) >= parseInt(firstShow) && parseInt(cT) <= parseInt(endShow)) {
                if (isOther) {
                    if (parseInt(endShow) > parseInt(other_control)) {
                        endShow = other_control;
                        cS = true;
                        cV = true
                    }
                } else {
                    if (parseInt(endShow) > parseInt(stu_control)) {
                        endShow = stu_control
                    }
                }
                if (!cS) {
                    cQ = false;
                    cP = false;
                    cU = false;
                    cW = endShow + 1
                }
            } else {
                cV = true;
                firstShow = cT;
                endShow = firstShow + 19;
                if (isOther) {
                    if (parseInt(endShow) > parseInt(other_control)) {
                        endShow = other_control;
                        cS = true
                    }
                } else {
                    if (parseInt(endShow) > parseInt(stu_control)) {
                        endShow = stu_control;
                        cS = true
                    }
                }
                if (!cS) {
                    cR = firstShow - 1;
                    cW = endShow + 1;
                    if (cR < cL) {
                        cQ = false
                    }
                }
            }
            if (isOther) {
                if (other_control < dataNumber) {
                    cX = true
                }
            } else {
                if (stu_control < dataNumber) {
                    cX = true
                }
            }
            if (cS) {
                cV = true;
                firstShow = endShow - 19;
                cR = firstShow - 1;
                if (cX) {
                    cP = true;
                    cW = endShow + 1;
                    cN = dataNumber
                } else {
                    cP = false
                }
                if (train_tour_flag != null && train_tour_flag != "" && train_tour_flag == "fc") {
                    $("#back_train_date").val(fullDateArr[cT - 1])
                } else {
                    $("#train_date").val(fullDateArr[cT - 1])
                }
            }
            if (parseInt(firstShow) < 1) {
                firstShow = 1
            }
            if (cQ) {
                for (var cO = cL; cO <= cR; cO++) {
                    $("#date_range>ul>li:nth-child(" + cO + ")").hide()
                }
            }
            if (cP) {
                for (var cO = cW; cO <= cN; cO++) {
                    $("#date_range>ul>li:nth-child(" + cO + ")").hide()
                }
            }
            if (cU) {
                for (var cO = firstShow; cO <= endShow; cO++) {
                    $("#date_range>ul>li:nth-child(" + cO + ")").show()
                }
            }
            $("#date_range>ul>li").removeClass("sel");
            if (cV) {
                $("#date_range>ul>li:nth-child(" + cY + ")").children("span:first").removeClass();
                $("#date_range>ul>li:nth-child(" + cY + ")").children("span:last").removeClass();
                $("#date_range>ul>li:nth-child(" + cM + ")").removeClass();
                $("#date_range>ul>li:nth-child(" + firstShow + ")").children("span:first").addClass("first");
                $("#date_range>ul>li:nth-child(" + firstShow + ")").children("span:last").addClass("first");
                $("#date_range>ul>li:nth-child(" + firstShow + ")").children().addClass("first");
                $("#date_range>ul>li:nth-child(" + endShow + ")").addClass("end")
            }
            $("#date_range>ul>li:nth-child(" + cT + ")").addClass("sel");
            $("#date_range>ul>li:nth-child(" + cT + ")").children("span:last-child").removeClass();
            $("#date_range>ul>li:nth-child(" + cT + ")").children("span:first-child").addClass("hide");
            cf = $("#date_range>ul>li:nth-child(" + cT + ")").children("span:first-child").text()
        }
    }
    function ca() {
        $("#query_ticket").unbind("click");
        $("#query_ticket_stu").unbind("click");
        $("#query_ticket").removeClass().addClass("btn92s btn-disabled");
        $("#query_ticket_stu").removeClass().addClass("btn92s btn-disabled");
        bD();
        setTimeout(function() {
            cI();
            bz();
            $("#query_ticket").removeClass().addClass("btn92s");
            $("#query_ticket_stu").removeClass().addClass("btn92s");
            if (train_tour_flag != "gc" && train_tour_flag != "fc") {
                if (ClickWho == "0X00") {
                    $("#query_ticket").unbind();
                    $("#query_ticket").removeClass().addClass("btn92s btn-disabled");
                    $("#query_ticket_stu").removeClass().addClass("btn92s")
                }
                if (ClickWho == "00") {
                    $("#query_ticket_stu").unbind();
                    $("#query_ticket_stu").removeClass().addClass("btn92s btn-disabled");
                    $("#query_ticket").removeClass().addClass("btn92s")
                }
            }
            if (isstudentDate) {
                $("#query_ticket_stu").unbind();
                $("#query_ticket_stu").removeClass().addClass("btn92s btn-disabled");
                $("#query_ticket").removeClass().addClass("btn92s")
            }
        },
        1000)
    }
    changeArriveDate = function(cM, cL) {
        cM = cM.replace(":", "");
        cL = cL.replace(":", "");
        hour_value = Number(cM.substring(0, 2)) + Number(cL.substring(0, 2));
        min_value = Number(cM.substring(2, 4)) + Number(cL.substring(2, 4));
        if (min_value >= 60) {
            hour_value = hour_value + 1
        }
        if (hour_value >= 24 && hour_value < 48) {
            return "次日"
        } else {
            if (hour_value >= 48 && hour_value < 72) {
                return "两日"
            } else {
                if (hour_value >= 72) {
                    return "三日"
                } else {
                    return "当日"
                }
            }
        }
    };
    changeLiShi = function(cL) {
        if (cL.substring(0, 1) == "0") {
            if (cL.substring(1, 2) == "0") {
                if (cL.substring(3, 4) == "0") {
                    cL = cL.substring(4, 5) + "分"
                } else {
                    cL = cL.substring(3, 5) + "分"
                }
            } else {
                cL = cL.substring(1, 2) + "小时" + cL.substring(3, 5) + "分"
            }
        } else {
            if (cL.substring(3, 5) == "00") {
                cL = cL.substring(0, 2) + "小时"
            } else {
                cL = cL.substring(0, 2) + "小时" + cL.substring(3, 5) + "分"
            }
        }
        return cL
    };
    isNum = function(cL) {
        return parseInt(cL)
    };
    buttonText = function() {
        return "预订"
    };
    function aA() {
        if ($("#sf2").is(":checked")) {
            if (G($("#train_date").val()) > G(init_maxPeriod) - 24 * 60 * 60 * 1000) {
                bD()
            } else {
                bz()
            }
        }
    }
    function aB() {
        if (train_tour_flag == "fc") {
            var cL = $("#back_train_date").val();
            D("back_train_date")
        } else {
            var cL = $("#train_date").val();
            D("train_date")
        }
        if (rqChecked.length == 0) {
            rqChecked.push(cL)
        }
        var cM = false;
        if (cL != rqChecked[0]) {
            for (var cN = 0; cN < rqChecked.length; cN++) {
                if (cL == rqChecked[cN]) {
                    cM = true;
                    rqChecked.splice(cN, 1);
                    $("#date-list input[scode=" + rqChecked[0] + "]").prop("checked", false);
                    rqChecked.splice(0, 1, cL);
                    $("#prior_date span[name=" + cL + "]").remove();
                    break
                }
            }
            if (!cM) {
                $("#date-list input[scode=" + rqChecked[0] + "]").prop("checked", false);
                rqChecked.splice(0, 1, cL);
                $("#date-list input[scode=" + rqChecked[0] + "]").prop("checked", true)
            }
        }
    }
    $("#train_date").focus(function() {
        $("#train_date").jcalendar({
            isSingle: false,
            startDate: $.getMindateForCal(),
            endDate: $.getMaxdateForCal(),
            onpicked: function() {
                aB();
                $("#train_date").blur();
                var cL = $("#train_date").val();
                var cM = $("#back_train_date").val();
                if ($("#wf").is(":checked")) {
                    if (!cM | G(cL) > G(cM)) {
                        $("#back_train_date").val(cL)
                    }
                }
                bc()
            }
        })
    });
    $("#date_icon_1").click(function() {
        $("#train_date").focus()
    });
    $("#back_train_date").focus(function() {
        $("#back_train_date").jcalendar({
            isSingle: false,
            startDate: $("#train_date").val(),
            endDate: $.getMaxdateForCal(),
            onpicked: function() {
                aB();
                $("#back_train_date").blur();
                bc()
            }
        })
    });
    $("#date_icon_2").click(function() {
        $("#back_train_date").focus()
    });
    String.prototype.toDate = function() {
        style = "yyyy-MM-dd hh:mm";
        var cO = {
            "y+": "y",
            "M+": "M",
            "d+": "d",
            "h+": "h",
            "m+": "m"
        };
        var cL = {
            y: "",
            M: "",
            d: "",
            h: "00",
            m: "00"
        };
        var cN = style;
        for (var cM in cO) {
            if (new RegExp("(" + cM + ")").test(style)) {
                cL[cO[cM]] = this.substring(cN.indexOf(RegExp.$1), cN.indexOf(RegExp.$1) + RegExp.$1.length)
            }
        }
        return new Date(cL.y, cL.M - 1, cL.d, cL.h, cL.m)
    };
    function D(cP) {
        if (cP == "back_train_date" && ClickWho != "0X00") {
            return
        }
        var cL = ($("#" + cP).val().split(" ")[0] + " 00:00:00").toDate().getTime();
        var cR = stu_start_train_date.split("&");
        var cN = stu_end_tain_date.split("&");
        var cM = false;
        for (var cO = 0,
        cQ = cR.length; cO < cQ; cO++) {
            if (cL >= cR[cO].toDate().getTime() && cL <= cN[cO].toDate().getTime()) {
                cM = true;
                break
            }
        }
        if (cM) {
            $("#sf2").attr("disabled", false);
            $("#sf2_label").removeClass("color999")
        } else {
            $("#sf2").attr("checked", false);
            $("#sf1")[0]["checked"] = "checked";
            $("#sf2").attr("disabled", true);
            $("#sf2_label").addClass("color999")
        }
    }
    function ck(cL) {
        if (isSaveQueryLog == "Y") {
            $.ajax({
                type: "get",
                isTakeParam: false,
                beforeSend: function(cM) {
                    cM.setRequestHeader("If-Modified-Since", "0");
                    cM.setRequestHeader("Cache-Control", "no-cache")
                },
                url: ctx + "leftTicket/log",
                data: cL,
                timeout: 15000,
                error: function(cM, cO, cN) {},
                success: function(cM) {}
            })
        }
    }
    var a9 = 0;
    var af = new Array();
    function ac() {
        $("div#id-seat-sel div.sel-item a").on("click",
        function() {
            if ($(this).attr("class") == "cur") {
                $(this).removeClass("cur");
                a9--;
                var cM = $(this).attr("id");
                $.each(af,
                function(cN, cP) {
                    var cO = $(cP).attr("id");
                    if (cM == cO) {
                        af.splice(cN, 1)
                    }
                });
                $("#selectNo").html(a9 + "/" + tickets_info.length)
            } else {
                af.push($(this));
                $(this).addClass("cur");
                if (a9 == tickets_info.length) {
                    var cL = af[a9 - 1];
                    $(cL).removeClass("cur");
                    af.splice(a9 - 1, 1);
                    return
                }
                a9++;
                $("#selectNo").html(a9 + "/" + tickets_info.length)
            }
        })
    }
    function ab() {
        aw();
        if (tickets_info && tickets_info.length > 0) {
            var cP = "Y";
            var cL = tickets_info[0].seat_type;
            for (var cO = 0; cO < tickets_info.length; cO++) {
                var cN = tickets_info[cO];
                if (cN.seat_type != cL) {
                    cP = "N";
                    break
                }
            }
            if (canChooseSeats && "Y" == canChooseSeats && "Y" == cP) {
                if (choose_Seats) {
                    var cM = "*如果本次列车剩余席位无法满足您的选座需求，系统将自动为您分配席位。";
                    if ("M" == cL && choose_Seats.indexOf("M") > -1) {
                        $("#id-seat-sel").css("display", "block");
                        $("#yideng1").css("display", "block");
                        if (tickets_info.length > 1) {
                            $("#yideng2").css("display", "block")
                        }
                        $("#notice_1_id").html(cM)
                    }
                    if ("O" == cL && choose_Seats.indexOf("O") > -1) {
                        $("#id-seat-sel").css("display", "block");
                        $("#erdeng1").css("display", "block");
                        if (tickets_info.length > 1) {
                            $("#erdeng2").css("display", "block")
                        }
                        $("#notice_1_id").html(cM)
                    }
                    if ("P" == cL && choose_Seats.indexOf("P") > -1) {
                        $("#id-seat-sel").css("display", "block");
                        $("#tedeng1").css("display", "block");
                        if (tickets_info.length > 1) {
                            $("#tedeng2").css("display", "block")
                        }
                        $("#notice_1_id").html(cM)
                    }
                    if ("9" == cL && choose_Seats.indexOf("9") > -1) {
                        $("#id-seat-sel").css("display", "block");
                        $("#tedeng1").css("display", "block");
                        if (tickets_info.length > 1) {
                            $("#tedeng2").css("display", "block")
                        }
                        $("#notice_1_id").html(cM)
                    }
                }
            }
        }
    }
    function aw() {
        $("div#id-seat-sel div.sel-item a").removeClass("cur");
        a9 = 0;
        af = new Array();
        $("#selectNo").html(a9 + "/" + tickets_info.length);
        $("#id-seat-sel.sel-item").css("display", "none");
        $("#id-seat-sel").css("display", "none");
        $("#notice_1_id").html("");
        $("#yideng1").css("display", "none");
        $("#yideng2").css("display", "none");
        $("#erdeng1").css("display", "none");
        $("#erdeng2").css("display", "none");
        $("#tedeng1").css("display", "none");
        $("#tedeng2").css("display", "none")
    }
    function bZ() {
        var cL = "";
        $.each($("div#id-seat-sel div.seat-sel-bd a"),
        function() {
            if ($(this).attr("class") == "cur") {
                var cM = $(this).attr("id");
                cL += cM
            }
        });
        return cL
    }
    function bE() {
        if (a9 != 0 && a9 != tickets_info.length) {
            $("#sy_ticket_num_id").html("<span style='color:red;'>请按照乘车人个数选座对应的席位。</span>");
            return false
        } else {
            return true
        }
    }
    function ct() {
        cn();
        if (tickets_info && tickets_info.length > 0) {
            if (canChooseBeds && "Y" == canChooseBeds) {
                $("#id-bed-sel").css("display", "block");
                $("#notice_1_id").html("*选铺后如果系统票额不足，系统将随机为您申请铺位。");
                if (isCanChooseMid && "Y" == isCanChooseMid) {
                    $("#mid_bed").css("display", "block")
                } else {
                    $("#mid_bed").css("display", "none")
                }
            } else {
                $("#id-bed-sel").css("display", "none")
            }
        }
    }
    numSet = function(cO, cL) {
        var cT = parseInt($("#x_no").text());
        var cP = parseInt($("#z_no").text());
        var cN = parseInt($("#s_no").text());
        var cR = tickets_info.length;
        var cM = cT + cP + cN;
        if ("add" == cO) {
            if (cM < cR) {
                var cS = document.getElementById(cL).innerText;
                var cQ = parseInt(cS) + 1;
                document.getElementById(cL).innerText = cQ;
                $("#selectBedNo").html(cM + 1 + "/" + cR)
            }
        } else {
            var cS = document.getElementById(cL).innerText;
            if (cM > 0 && parseInt(cS) > 0) {
                var cQ = parseInt(cS) - 1;
                document.getElementById(cL).innerText = cQ;
                $("#selectBedNo").html(cM - 1 + "/" + cR)
            }
        }
    };
    function cn() {
        $("#x_no").html("0");
        $("#z_no").html("0");
        $("#s_no").html("0");
        $("#selectBedNo").html(0 + "/" + tickets_info.length);
        $("#confirmDiv").css("padding", "20px 0");
        $("#checktrain").css("display", "none")
    }
    function a1() {
        var cL = $("#x_no").text();
        var cM = $("#z_no").text();
        var cN = $("#s_no").text();
        return cL + cM + cN
    }
})();
function checkG1234(g, f, c, h, b) {
    var a = "99999GGGGG";
    var e = "##CCT##PPT##CPT##PXT##SBT##PBD##JOD##HPD##SHD##QTP##TSP##TJP##";
    var d = "##CBP##DIP##JGK##ZEK##UUH##NKH##ESH##OHH##AOH##";
    if (c.indexOf(a) > -1 && e.indexOf(h) > -1 && d.indexOf(b) > -1) {
        dhtmlx.createWin({
            winId: "confirmG1234",
            closeWinId: ["close_conifrmdialog_G1234", "cancel_dialog_G1234"],
            okId: "goto_integration_G1234",
            okCallBack: function() {
                submitOrderRequest(g, f)
            },
            callback: function() {
                return
            }
        })
    } else {
        submitOrderRequest(g, f)
    }
}
function checkRandCodeUAM(e) {
    var b = false,
    a = e.value,
    c = "sjrand",
    d = TouClick.get("touclick-" + e.id);
    $.ajax({
        url: passport_captcha_check,
        type: "post",
        dataType: "json",
        xhrFields: {
            withCredentials: true
        },
        data: {
            answer: a,
            login_site: "E",
            rand: c
        },
        async: false,
        success: function(f) {
            if (f.result_code == "4") {
                b = true;
                d.success();
                setTimeout(function() {
                    if (d.getState() === "success") {
                        d.reload()
                    }
                },
                3000)
            } else {
                b = false;
                var g = f.result_message;
                d.fail()
            }
        }
    });
    return b
}
function refreshImgUAM(c, e, d) {
    if ($(".login .touclick-image").attr("src").indexOf(passport_captcha) != -1) {
        TouClick.get("touclick-" + TouLocal.getRandCodeName(d)).reload();
        return
    }
    var h = "randCode";
    if (targetelement[0] !== "") {
        h += "_" + targetelement[0]
    }
    var b = $("#" + targetdiv[0]),
    g = b.data("code_type");
    var j = "sjrand";
    var f = "E";
    var a = passport_captcha + "?login_site=" + f + "&module=" + g + "&rand=" + j;
    TouClick.ready(function() {
        var k = TouClick.get("touclick-" + h).start({
            gp_url: a,
            onClick: function(m) {
                var o = $("#" + h);
                o.val(m);
                var n = $("#error_msg" + targetdiv[0]);
                var l = o[0];
                if (n.data("tag") === 1) {
                    n.hide()
                }
            },
            onReload: function() {
                $("#" + h).val("");
                $("#error_msg").css("display", "none");
                var l = $.jc_getcookie("current_captcha_type")
            },
            onReloading: function() {
                return true
            }
        })
    });
    TouClick.get("touclick-" + TouLocal.getRandCodeName(d)).reload();
    $(".login .touclick-image").attr("src", a)
}
function verifyRandCodeUAM(d, b) {
    if (typeof(b) !== "boolean") {
        showError(d, b);
        return false
    }
    var a = d.value;
    var c = typeof(TouLocal.getErrorMessage) === "function" ? TouLocal.getErrorMessage(d) : login_messages.pleaseClickCaptcha;
    if ("" == a || null == a) {
        showError(d, c, 1);
        return false
    }
    if (!checkRandCodeUAM(d)) {
        c = typeof(TouLocal.getErrorMessage) === "function" ? TouLocal.getErrorMessage(d, false) : login_messages.pleaseClickCaptcha;
        showError(d, c, 1);
        return false
    }
    showError(d).hide();
    return true
};
var left_ticket_messages = {
    "leftTicketDTO.from_station": "出发站",
    "leftTicketDTO.to_station": "目的站",
    "leftTicketDTO.train_no": "车次",
    "leftTicketDTO.train_date": "出发日",
    back_train_date: "返程日"
};
jQuery.validator.addMethod("checkLoginUserName",
function(f, d) {
    var a = false;
    var c = /^(13[0-9])|(14[0-9])|(15[0-9])|(18[0-9])|(17[0-9])|(19[0-9])|(16[0-9])\d{8}$/;
    var b = /^[A-Za-z]{1}([A-Za-z0-9]|[_]){0,29}$/;
    var e = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$/i;
    if (b.test(f) || e.test(f) || c.test(f)) {
        a = true
    }
    return this.optional(d) || a
},
"wrong username.");
jQuery.validator.addMethod("requiredUserName",
function(b, a) {
    if ("用户名／邮箱／手机号" == b) {
        return false
    }
    if (b == null || "" == b) {
        return false
    }
    return true
},
"wrong username.");
jQuery.validator.addMethod("requiredSchoolName",
function(b, a) {
    if ("简码／汉字" == b) {
        return false
    }
    if (b == null || "" == b) {
        return false
    }
    return true
},
"wrong schoolname.");
jQuery.validator.addMethod("randCodeRequired",
function(b, a) {
    $("#i-ok").css("display", "none");
    return b.length > 0
},
"验证码错误!");
jQuery.validator.addMethod("randCodeFormat",
function(c, b) {
    $("#i-ok").css("display", "none");
    var a = /^[a-zA-Z0-9]+$/;
    return this.optional(b) || a.test(c)
},
"验证码错误!");
jQuery.validator.addMethod("randCodeLength",
function(b, a) {
    $("#i-ok").css("display", "none");
    return b.length == 4
},
"验证码错误!.");
jQuery.validator.addMethod("integrationCheck",
function(b, a) {
    var c = /^\d{6}$/;
    return this.optional(a) || c.test(b)
},
"wrong integrationpassword");
jQuery.validator.addMethod("integrationPwdCheck",
function(b, a, c) {
    if ($("#" + c[0]).val() == $("#" + c[1]).val()) {
        return true
    }
    return false
},
"两次输入密码不一致!.");
jQuery.validator.addMethod("checkRandCode",
function(c, b, d) {
    var a = true;
    if (c && c.length == 4) {
        $.ajax({
            url: ctx + "passcodeNew/checkRandCodeAnsyn",
            type: "post",
            data: {
                randCode: c,
                rand: d
            },
            async: false,
            success: function(e) {
                if (e.data == "N") {
                    a = false;
                    $("#i-ok").css("display", "none")
                } else {
                    a = true;
                    $("#i-ok").css("display", "block")
                }
            }
        })
    } else {
        a = false;
        $("#i-ok").css("display", "none")
    }
    return a
},
"验证码错误!.");
jQuery.validator.addMethod("validateUsersName",
function(b, a) {
    return this.optional(a) || /^[A-Za-z]{1}([A-Za-z0-9]|[_]){0,29}$/.test(b)
},
"用户名只能由字母、数字或_组成");
jQuery.validator.addMethod("checkWriteSpace",
function(c, b) {
    for (var a = 0; a < c.length; a++) {
        if (c.charCodeAt(a) == 32) {
            return false
        }
    }
    return true
},
"contain writespace");
jQuery.validator.addMethod("validateRandCode",
function(b, a) {
    return this.optional(a) || /^[a-zA-Z0-9]+$/.test(b)
},
"验证码错误!.");
jQuery.validator.addMethod("checkPassward",
function(c, b, e) {
    var d = true;
    for (var a = 0; a < c.length; a++) {
        if (c.charCodeAt(a) == 39 || c.charCodeAt(a) == 60 || c.charCodeAt(a) == 62) {
            d = false
        }
        if (!d) {
            break
        }
    }
    return this.optional(b) || d
},
"Passward wrong");
function validateSecIdCard(g) {
    var f = 0;
    var a = g;
    var e = {
        11 : "北京",
        12 : "天津",
        13 : "河北",
        14 : "山西",
        15 : "内蒙",
        21 : "辽宁",
        22 : "吉林",
        23 : "黑龙",
        31 : "上海",
        32 : "江苏",
        33 : "浙江",
        34 : "安徽",
        35 : "福建",
        36 : "江西",
        37 : "山东",
        41 : "河南",
        42 : "湖北",
        43 : "湖南",
        44 : "广东",
        45 : "广西",
        46 : "海南",
        50 : "重庆",
        51 : "四川",
        52 : "贵州",
        53 : "云南",
        54 : "西藏",
        61 : "陕西",
        62 : "甘肃",
        63 : "青海",
        64 : "宁夏",
        65 : "新疆",
        71 : "台湾",
        81 : "香港",
        82 : "澳门",
        83 : "台湾",
        91 : "国外"
    };
    if (!/^\d{17}(\d|x)$/i.test(a)) {
        return false
    }
    a = a.replace(/x$/i, "a");
    if (e[parseInt(a.substr(0, 2))] == null) {
        return false
    }
    var c = a.substr(6, 4) + "-" + Number(a.substr(10, 2)) + "-" + Number(a.substr(12, 2));
    var h = new Date(c.replace(/-/g, "/"));
    if (c != (h.getFullYear() + "-" + (h.getMonth() + 1) + "-" + h.getDate())) {
        return false
    }
    for (var b = 17; b >= 0; b--) {
        f += (Math.pow(2, b) % 11) * parseInt(a.charAt(17 - b), 11)
    }
    if (f % 11 != 1) {
        return false
    }
    return true
}
function validateFirIdCard(g) {
    var f = 0;
    var a;
    var e = {
        11 : "北京",
        12 : "天津",
        13 : "河北",
        14 : "山西",
        15 : "内蒙",
        21 : "辽宁",
        22 : "吉林",
        23 : "黑龙",
        31 : "上海",
        32 : "江苏",
        33 : "浙江",
        34 : "安徽",
        35 : "福建",
        36 : "江西",
        37 : "山东",
        41 : "河南",
        42 : "湖北",
        43 : "湖南",
        44 : "广东",
        45 : "广西",
        46 : "海南",
        50 : "重庆",
        51 : "四川",
        52 : "贵州",
        53 : "云南",
        54 : "西藏",
        61 : "陕西",
        62 : "甘肃",
        63 : "青海",
        64 : "宁夏",
        65 : "新疆",
        71 : "台湾",
        81 : "香港",
        82 : "澳门",
        83 : "台湾",
        91 : "国外"
    };
    if (g.length == 15) {
        a = idCardUpdate(g)
    } else {
        a = g
    }
    if (!/^\d{17}(\d|x)$/i.test(a)) {
        return false
    }
    a = a.replace(/x$/i, "a");
    if (e[parseInt(a.substr(0, 2))] == null) {
        return false
    }
    var c = a.substr(6, 4) + "-" + Number(a.substr(10, 2)) + "-" + Number(a.substr(12, 2));
    var h = new Date(c.replace(/-/g, "/"));
    if (c != (h.getFullYear() + "-" + (h.getMonth() + 1) + "-" + h.getDate())) {
        return false
    }
    for (var b = 17; b >= 0; b--) {
        f += (Math.pow(2, b) % 11) * parseInt(a.charAt(17 - b), 11)
    }
    if (f % 11 != 1) {
        return false
    }
    return true
}
function idCardUpdate(g) {
    var b;
    var f = /^(\d){15}$/;
    if (f.test(g)) {
        var e = 0;
        var a = new Array(7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2);
        var d = new Array("1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2");
        g = g.substr(0, 6) + "19" + g.substr(6, g.length - 6);
        for (var c = 0; c < g.length; c++) {
            e += parseInt(g.substr(c, 1)) * a[c]
        }
        g += d[e % 11];
        b = g
    } else {
        b = "#"
    }
    return b
}
jQuery.validator.addMethod("checkBorth",
function(e, c) {
    var b = e;
    if (b == "") {
        return true
    } else {
        var a = b.match(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$/);
        if (a == null) {
            return false
        }
        var f = new Date(a[1], a[3] - 1, a[4]);
        return (f.getFullYear() == a[1] && (f.getMonth() + 1) == a[3] && f.getDate() == a[4])
    }
},
"日期格式不合法");
jQuery.validator.addMethod("byteRangeLength",
function(d, b, e) {
    var c = d.length;
    for (var a = 0; a < d.length; a++) {
        if (d.charCodeAt(a) > 127) {
            c++
        }
    }
    return this.optional(b) || (c >= e[0] && c <= e[1])
},
"length wrong");
jQuery.validator.addMethod("checkNameCharBlank",
function(c, b, d) {
    var a = d.split("@");
    if ($("#" + a[1]).val() == "") {
        return true
    } else {
        if ($("#" + a[0]).val() == "1" || $("#" + a[0]).val() == "2") {
            return this.optional(b) || /^[a-zA-Z·.．\u3400-\u9FFF]+$/.test(c)
        } else {
            if ($("#" + a[0]).val() == "B") {
                if (/^[-]+$/.test(c)) {
                    return false
                }
                return this.optional(b) || /^[a-z A-Z·.．\u3400-\u9FFF\-]+$/.test(c)
            } else {
                if ($("#" + a[0]).val() == "H") {
                    return true
                } else {
                    return this.optional(b) || /^[a-z A-Z·.．\u3400-\u9FFF]+$/.test(c)
                }
            }
        }
    }
},
"wrong name.");
jQuery.validator.addMethod("checkNameCharBlankForWork",
function(c, b, d) {
    var a = d.split("@");
    if ($("#" + a[0]).val() == "H") {
        return this.optional(b) || /^[a-zA-Z ]+$/.test(c)
    } else {
        return true
    }
},
"wrong name.");
jQuery.validator.addMethod("checkIdValidStr",
function(c, b) {
    var a = /^[a-zA-Z0-9\_\-\(\)]+$/;
    return this.optional(b) || (a.test(c))
},
"wrong id");
jQuery.validator.addMethod("isSecIDCard",
function(b, a, c) {
    if (!checkIfSecIdCard($(c).val())) {
        return true
    }
    return validateSecIdCard(b)
},
"wrong");
function checkIfSecIdCard(a) {
    if (a == "1") {
        return true
    }
    return false
}
function checkIfFirIdCard(a) {
    if (a == "2") {
        return true
    }
    return false
}
function checkCardForHKorTW(a) {
    if (a == "C" || a == "G") {
        return true
    }
    return false
}
jQuery.validator.addMethod("isFirIDCard",
function(b, a, c) {
    if (!checkIfFirIdCard($(c).val())) {
        return true
    }
    return validateFirIdCard(b)
},
"wrong");
jQuery.validator.addMethod("checkHkongMacaoOld",
function(c, b, d) {
    if ($(d).val() == "C") {
        var a = /^[HMhm]{1}([0-9]{10}|[0-9]{8})$/;
        return this.optional(b) || (a.test(c))
    } else {
        return true
    }
},
"wrong format.");
jQuery.validator.addMethod("checkTaiwOld",
function(c, a, e) {
    if ($(e).val() == "G") {
        var d = /^[0-9]{8}$/;
        var b = /^[0-9]{10}$/;
        return this.optional(a) || (d.test(c)) || (b.test(c))
    } else {
        return true
    }
},
"wrong format.");
jQuery.validator.addMethod("checkHkongMacao",
function(c, b, d) {
    if ($(d).val() == "C") {
        var a = /^[HMhm]{1}([0-9]{8})$/;
        return this.optional(b) || (a.test(c))
    } else {
        return true
    }
},
"wrong format.");
jQuery.validator.addMethod("checkTaiw",
function(b, a, d) {
    if ($(d).val() == "G") {
        var c = /^[0-9]{8}$/;
        return this.optional(a) || (c.test(b))
    } else {
        return true
    }
},
"wrong format.");
jQuery.validator.addMethod("checkPassport",
function(d, b, e) {
    if ($(e).val() == "B") {
        var c = /^[a-zA-Z]{5,17}$/;
        var a = /^[a-zA-Z0-9]{5,17}$/;
        return this.optional(b) || (a.test(d)) || c.test(d)
    } else {
        return true
    }
},
"wrong format.");
jQuery.validator.addMethod("checkWork",
function(c, b, d) {
    if ($(d).val() == "H") {
        var a = /^[a-zA-Z]{3}[0-9]{12}$/;
        return this.optional(b) || (a.test(c))
    } else {
        return true
    }
},
"wrong format.");
jQuery.validator.addMethod("checkGATJmjzz",
function(d, b, e) {
    var a = e.split("@");
    if ($("#" + a[0]).val() == "1") {
        var c = d.substring(0, 2);
        if ($("#" + a[1]).is(":checked")) {
            if (c != "81" && c != "82" && c != "83") {
                return false
            }
        } else {
            if (c == "81" || c == "82" || c == "83") {
                return false
            }
        }
    }
    return true
},
"wrong format.");
jQuery.validator.addMethod("isMobile",
function(d, b) {
    var c = d.length;
    var a = /^(13[0-9])|(14[0-9])|(15[0-9])|(18[0-9])|(17[0-9])|(19[0-9])|(16[0-9])\d{8}$/;
    return this.optional(b) || (c == 11 && a.test(d))
},
"wrong mobile phone ");
jQuery.validator.addMethod("isTelePhone",
function(b, a) {
    var c = /(^[0-9]{3,4}\-[0-9]{3,8}$)|(^[0-9]{3,8}$)|(^[0-9]{3,4}\)[0-9]{3,8}$)|(^0{0,1}13[0-9]{9}#)/;
    return this.optional(a) || (c.test(b))
},
"wrong telePhone ");
jQuery.validator.addMethod("illegalChar",
function(c, b, e) {
    var d = true;
    if (c.indexOf("$") >= 0) {
        return false
    }
    for (var a = 0; a < c.length; a++) {
        if (c.charCodeAt(a) == 39 || c.charCodeAt(a) == 60 || c.charCodeAt(a) == 62 || c.charCodeAt(a) == 34 || c.charCodeAt(a) == 63) {
            d = false
        }
        if (!d) {
            break
        }
    }
    return this.optional(b) || d
},
"Illegal char wrong");
jQuery.validator.addMethod("isZipCode",
function(c, b) {
    var a = /^[0-9]{6}$/;
    return this.optional(b) || (a.test(c))
},
"wrong zipcode");
jQuery.validator.addMethod("isEmail",
function(c, a) {
    var b = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return this.optional(a) || (b.test(trim(c)))
},
"wrong email");
function replaceChar(b) {
    var a = b.value.replace(/['"<> ?]/g, "");
    b.value = a
}
function checkNameChar1(a) {
    return /^[a-zA-Z0-9\u3400-\u9FFF]+$/.test(a)
}
function trim(a) {
    return a.replace(/(^\s*)|(\s*$)/g, "")
}
function ltrim(a) {
    return a.replace(/(^\s*)/g, "")
}
function rtrim(a) {
    return a.replace(/(\s*$)/g, "")
}
jQuery.validator.addMethod("validateName",
function(b, a) {
    return this.optional(a) || /^[a-zA-Z\u3400-\u9FFF0-9\_]+$/.test(b)
},
"wrong username.");
jQuery.validator.addMethod("studentRequired",
function(b, a, c) {
    if ($(c).val() == "3") {
        return b && trim(b) != ""
    }
    return true
},
"wrong studentRequired.");
jQuery.validator.addMethod("studentStationRequired",
function(b, a, c) {
    if ($(c).val() == "3") {
        return b && trim(b) != "简拼/全拼/汉字" && trim(b) != ""
    }
    return true
},
"wrong studentStationRequired.");
jQuery.validator.addMethod("studentValidateName",
function(b, a, c) {
    if ($(c).val() == "3") {
        return this.optional(a) || /^[a-zA-Z\u3400-\u9FFF0-9\_]+$/.test(b)
    }
    return true
},
"wrong username.");
jQuery.validator.addMethod("checkStudentName",
function(b, a, c) {
    if ($(c).val() == "3") {
        if ((!b || trim(b) == "" || trim(b) == "简码/汉字")) {
            return false
        }
    }
    return true
},
"wrong username.");
jQuery.validator.addMethod("isQuestionNull",
function(b, a, c) {
    if (jQuery.trim(b) != "") {
        if (jQuery.trim($(c[0]).val()) == "customQuestion" && jQuery.trim($(c[1]).val()) == "" || jQuery.trim($(c[0]).val()) == "") {
            return false
        }
    }
    return true
},
"you should input the question");
jQuery.validator.addMethod("isAnswerNull",
function(b, a, c) {
    if ((jQuery.trim($(c[0]).val()) == "customQuestion" && jQuery.trim($(c[1]).val()) != "") || (jQuery.trim($(c[0]).val()) != "")) {
        if (jQuery.trim(b) == "") {
            return false
        }
    }
    return true
},
"you should input the answer");
function checkSex(c, b, a) {
    if (!checkSexByCardId(c, b, a)) {
        if (!confirm("性别与身份证中的性别不符，是否继续?")) {
            return false
        } else {
            return true
        }
    } else {
        return true
    }
}
function checkSexByCardId(c, e, a) {
    function b(h, i) {
        var g = null;
        if (i.length == 15) {
            g = i.substring(14, 15)
        } else {
            if (i.length == 18) {
                g = i.substring(16, 17)
            } else {
                return true
            }
        }
        if (g == "x" || g == "X") {
            g = "10"
        }
        var f = parseInt(g);
        var j = f % 2;
        if (j === 0 && h === "F") {
            return true
        } else {
            if (j === 1 && h === "M") {
                return true
            } else {
                return false
            }
        }
    }
    var d = $(a).val();
    if (checkIfSecIdCard($(e).val()) && validateSecIdCard(d)) {
        if (d !== "") {
            return b(c, d)
        } else {
            return true
        }
    } else {
        if (checkIfFirIdCard($(e).val()) && validateFirIdCard(d)) {
            if (d !== "") {
                return b(c, d)
            } else {
                return true
            }
        } else {
            return true
        }
    }
}
function checkBirdDateByCardId(c, e, b) {
    var a = null;
    var d = $(b).val();
    if (checkIfSecIdCard($(e).val()) && d !== "" && validateSecIdCard(d)) {
        a = d.substring(6, 14)
    } else {
        if (checkIfFirIdCard($(e).val()) && d !== "" && validateFirIdCard(d)) {
            if (d.length == 15) {
                a = "19" + d.substring(6, 12)
            } else {
                if (d.length == 18) {
                    a = d.substring(6, 14)
                }
            }
        } else {
            return true
        }
    }
    if (c !== "") {
        c = c.replace(/-/g, "");
        if (c != a) {
            return false
        } else {
            return true
        }
    } else {
        return true
    }
}
function checkBirdate(c, b, a) {
    if (!checkBirdDateByCardId(c, b, a)) {
        if (!confirm("出生日期与身份证中的出生日期不符，是否继续?")) {
            return false
        } else {
            return true
        }
    } else {
        return true
    }
}
jQuery.validator.addMethod("checkPwdValidate",
function(b, a) {
    return this.optional(a) || /(?![a-z]+$|[0-9]+$|_+$)^[a-zA-Z0-9_]{6,}$/.test(b)
},
"contain writespace");
jQuery.validator.addMethod("checkConfirmPassWard",
function(b, a, c) {
    if ($(c).val() != null) {
        return $(c).val() == b
    }
    return true
},
"contain writespace");
jQuery.validator.addMethod("IVR_passwd_format",
function(b, a) {
    var c = /^[0-9]{6}$/;
    return this.optional(a) || c.test(b)
},
"验证码错误!.");
jQuery.validator.addMethod("checkStation",
function(b, a) {
    if ((!b || trim(b) == "" || trim(b) == "简拼/全拼/汉字" || trim(b) == "简拼/全拼/汉字或↑↓")) {
        return false
    }
    return true
},
"wrong username.");
jQuery.validator.addMethod("checkAnsyUserName",
function(e, c, f) {
    var b = f[0];
    var d = $("#" + f[1]).val();
    var a = true;
    $.ajax({
        url: b + "?user_name=" + e,
        type: "get",
        async: false,
        success: function(g, h) {
            if (g.data == true) {
                a = false
            } else {
                a = true
            }
        },
        error: function(g, i, h) {
            a = false
        }
    });
    return a
},
"wrong cardNo");
function checkPwdRank(e, a, d) {
    var b = $(e);
    var c = b.val();
    if (c.length <= 6 || new RegExp("^[a-zA-Z]{6,}$").test(c) || new RegExp("^[0-9]{6,}$").test(c) || new RegExp("^[_]{6,}$").test(c)) {
        $("#" + a).attr("title", "危险");
        $("#" + d).html("危险");
        $("#" + a).removeClass("rank-a");
        $("#" + a).removeClass("rank-b");
        $("#" + a).removeClass("rank-c");
        $("#" + a).addClass("rank-a")
    } else {
        if (c.length > 6 && new RegExp("[a-zA-Z]").test(c) && new RegExp("[0-9]").test(c) && new RegExp("[_]").test(c)) {
            $("#" + a).attr("title", "安全");
            $("#" + d).html("安全");
            $("#" + a).removeClass("rank-a");
            $("#" + a).removeClass("rank-b");
            $("#" + a).removeClass("rank-c");
            $("#" + a).addClass("rank-c")
        } else {
            $("#" + a).attr("title", "一般");
            $("#" + d).html("一般");
            $("#" + a).removeClass("rank-a");
            $("#" + a).removeClass("rank-b");
            $("#" + a).removeClass("rank-c");
            $("#" + a).addClass("rank-b")
        }
    }
}
Array.prototype.unique = function() {
    var b = {},
    a = this.length;
    for (var c = 0; c < a; c++) {
        if (typeof b[this[c]] == "undefined") {
            b[this[c]] = 1
        }
    }
    this.length = 0;
    a = 0;
    for (var c in b) {
        this[a++] = c
    }
    return this
};
function checkSearchPwdRank(h, c, g) {
    var e = $(h);
    var f = e.val();
    if (f.length < 6) {
        $("#" + c).attr("title", "危险");
        $("#" + g).html("危险");
        $("#" + c).removeClass("rank-a");
        $("#" + c).removeClass("rank-b");
        $("#" + c).removeClass("rank-c");
        $("#" + c).addClass("rank-a")
    } else {
        var a = [];
        for (var b = 0; b < 6; b++) {
            a.push(f.charAt(b))
        }
        a = a.unique();
        var d = a.length;
        if (d == 1) {
            $("#" + c).attr("title", "危险");
            $("#" + g).html("危险");
            $("#" + c).removeClass("rank-a");
            $("#" + c).removeClass("rank-b");
            $("#" + c).removeClass("rank-c");
            $("#" + c).addClass("rank-a")
        } else {
            if (d > 1 && d < 5) {
                $("#" + c).attr("title", "一般");
                $("#" + g).html("一般");
                $("#" + c).removeClass("rank-a");
                $("#" + c).removeClass("rank-b");
                $("#" + c).removeClass("rank-c");
                $("#" + c).addClass("rank-b")
            } else {
                $("#" + c).attr("title", "安全");
                $("#" + g).html("安全");
                $("#" + c).removeClass("rank-a");
                $("#" + c).removeClass("rank-b");
                $("#" + c).removeClass("rank-c");
                $("#" + c).addClass("rank-c")
            }
        }
    }
}
jQuery.validator.addMethod("checkDetailAddress",
function(b, a) {
    return this.optional(a) || /^[0-9a-zA-Z\u3400-\u9FFF\#]+$/.test(b)
},
"wrong name.");
jQuery.validator.addMethod("checkAddressName",
function(b, a) {
    if (/^[-]+$/.test(b)) {
        return false
    }
    return this.optional(a) || /^[a-z A-Z·.．\u3400-\u9FFF\-]+$/.test(b) || /^[a-zA-Z·.．\u3400-\u9FFF]+$/.test(b)
},
"wrong name.");
jQuery.validator.addMethod("checkAddressSelect",
function(b, a) {
    if ("" == b) {
        return false
    }
    if (b) {
        return true
    }
    return this.optional(a)
},
"wrong name.");
var login_messages = {
    randCodeError: "验证码错误!",
    randCodeExpired: "验证码失效",
    randCodeLentgh: "验证码长度为4位!",
    randCodeFormat: "验证码只能由数字或字母组成!",
    randCodeEmpty: "验证码不能为空!",
    userNameEmpty: "登录名必须填写!",
    userNameFormat: "登录名格式不正确，请重新输入!",
    passwordEmpty: "密码必须填写,且不少于6位!",
    passwordLength: "密码长度不能少于6位!",
    pleaseClickCaptcha: "请点击验证码",
    pleaseClickLeftCaptcha: "请点击左侧验证码",
    pleaseClickCaptchaRight: "请点击正确的验证码",
    pleaseClickBottomCaptcha: "请点击下方验证码",
    loginError: "当前访问用户过多,请稍候重试!",
    submitAfterVerify: "提交",
    pleaseClickSubmitButtonAfterClick: "pleaseClickSubmitButtonAfterClick",
    leftTicketOrderNoteMessage: '点击"提交"按钮获取验证码',
    leftTicketOrderClickCallbackNoteMessage: '完成选择后，继续点击下方橙色"提交"按钮提交订单',
    leftTicketOrderShowCallbackNoteMessage: "按照提示点击选择所有的图片",
    leftTicketOrderHiddenCallbackNoteMessage: '点击"提交"按钮获取验证码',
    getCaptchaByClick: "点击获取验证码"
};
function Marquee(a) {
    if (a == null || a == "") {
        return
    }
    this.ID = document.getElementById(a.ID);
    if (!this.ID) {
        this.id = -1;
        return
    }
    this.Direction = this.Width = this.Height = this.DelayTime = this.WaitTime = this.CTL = this.StartID = this.Stop = this.MouseOver = 0;
    this.Step = 1;
    this.Timer = 30;
    this.DirectionArray = {
        top: 0,
        up: 0,
        bottom: 1,
        down: 1,
        left: 2,
        right: 3
    };
    if (typeof a.Direction == "number" && a.Direction) {
        this.Direction = a.Direction
    }
    if (typeof a.Direction == "string" && a.Direction) {
        this.Direction = this.DirectionArray[a.Direction.toString().toLowerCase()]
    }
    if (typeof a.Step == "number" && a.Step) {
        this.Step = a.Step
    }
    if (typeof a.Width == "number" && a.Width) {
        this.Width = a.Width
    }
    if (typeof a.Height == "number" && a.Height) {
        this.Height = a.Height
    }
    if (typeof a.Timer == "number" && a.Timer) {
        this.Timer = a.Timer
    }
    if (typeof a.DelayTime == "number" && a.DelayTime) {
        this.DelayTime = a.DelayTime
    }
    if (typeof a.WaitTime == "number" && a.WaitTime) {
        this.WaitTime = a.WaitTime
    }
    if (typeof a.ScrollStep == "number" && a.ScrollStep) {
        this.ScrollStep = a.ScrollStep
    }
    this.ID.style.overflow = this.ID.style.overflowX = this.ID.style.overflowY = "hidden";
    this.ID.noWrap = true;
    this.IsNotOpera = (navigator.userAgent.toLowerCase().indexOf("opera") == -1);
    this.Start()
}
Marquee.prototype.Start = function() {
    if (this.ID == -1) {
        return
    }
    if (this.Width == 0) {
        this.Width = parseInt(this.ID.style.width)
    }
    if (this.Height == 0) {
        this.Height = parseInt(this.ID.style.height)
    }
    if (this.Timer < 20) {
        this.Timer = 20
    }
    if (this.WaitTime < 800) {
        this.WaitTime = 800
    }
    this.HalfWidth = Math.round(this.Width / 2);
    this.HalfHeight = Math.round(this.Height / 2);
    this.BakStep = this.Step;
    this.ID.style.width = this.Width + "px";
    this.ID.style.height = this.Height + "px";
    if (typeof this.ScrollStep != "number") {
        this.ScrollStep = this.Direction > 1 ? this.Width: this.Height
    }
    var d = "<table cellspacing='0' cellpadding='0' style='border-collapse:collapse;display:inline;'><tr><td noWrap=true style='white-space: nowrap;word-break:keep-all;padding-right:100px;'>MSCLASS_TEMP_HTML</td><td noWrap=true style='white-space: nowrap;word-break:keep-all;'>MSCLASS_TEMP_HTML</td></tr></table>";
    var b = "<table cellspacing='0' cellpadding='0' style='border-collapse:collapse;'><tr><td>MSCLASS_TEMP_HTML</td></tr><tr><td>MSCLASS_TEMP_HTML</td></tr></table>";
    var e = this;
    e.tempHTML = e.ID.innerHTML;
    if (e.Direction <= 1) {
        e.ID.innerHTML = b.replace(/MSCLASS_TEMP_HTML/g, e.ID.innerHTML)
    } else {
        if (e.ScrollStep == 0 && e.DelayTime == 0) {
            e.ID.innerHTML += e.ID.innerHTML
        } else {
            e.ID.innerHTML = d.replace(/MSCLASS_TEMP_HTML/g, e.ID.innerHTML)
        }
    }
    var f = this.Timer;
    var a = this.DelayTime;
    var c = this.WaitTime;
    e.StartID = function() {
        e.Scroll()
    };
    e.Continue = function() {
        if (e.MouseOver == 1) {
            setTimeout(e.Continue, a)
        } else {
            clearInterval(e.TimerID);
            e.CTL = e.Stop = 0;
            e.TimerID = setInterval(e.StartID, f)
        }
    };
    e.Pause = function() {
        e.Stop = 1;
        clearInterval(e.TimerID);
        setTimeout(e.Continue, a)
    };
    e.Begin = function() {
        e.ClientScroll = e.Direction > 1 ? e.ID.scrollWidth / 2 : e.ID.scrollHeight / 2;
        if ((e.Direction <= 1 && e.ClientScroll <= e.Height + e.Step) || (e.Direction > 1 && e.ClientScroll <= e.Width + e.Step)) {
            e.ID.innerHTML = e.tempHTML;
            delete(e.tempHTML);
            return
        }
        delete(e.tempHTML);
        e.TimerID = setInterval(e.StartID, f);
        if (e.ScrollStep < 0) {
            return
        }
        e.ID.onmousemove = function(g) {
            if (e.ScrollStep == 0 && e.Direction > 1) {
                var g = g || window.event;
                if (window.event) {
                    if (e.IsNotOpera) {
                        e.EventLeft = g.srcElement.id == e.ID.id ? g.offsetX - e.ID.scrollLeft: g.srcElement.offsetLeft - e.ID.scrollLeft + g.offsetX
                    } else {
                        e.ScrollStep = null;
                        return
                    }
                } else {
                    e.EventLeft = g.layerX - e.ID.scrollLeft
                }
                e.Direction = e.EventLeft > e.HalfWidth ? 3 : 2;
                e.AbsCenter = Math.abs(e.HalfWidth - e.EventLeft);
                e.Step = Math.round(e.AbsCenter * (e.BakStep * 2) / e.HalfWidth)
            }
        };
        e.ID.onmouseover = function() {
            if (e.ScrollStep == 0) {
                return
            }
            e.MouseOver = 1;
            clearInterval(e.TimerID)
        };
        e.ID.onmouseout = function() {
            if (e.ScrollStep == 0) {
                if (e.Step == 0) {
                    e.Step = 1
                }
                return
            }
            e.MouseOver = 0;
            if (e.Stop == 0) {
                clearInterval(e.TimerID);
                e.TimerID = setInterval(e.StartID, f)
            }
        }
    };
    setTimeout(e.Begin, c)
};
Marquee.prototype.Scroll = function() {
    switch (this.Direction) {
    case 0:
        this.CTL += this.Step;
        if (this.CTL >= this.ScrollStep && this.DelayTime > 0) {
            this.ID.scrollTop += this.ScrollStep + this.Step - this.CTL;
            this.Pause();
            return
        } else {
            if (this.ID.scrollTop >= this.ClientScroll) {
                this.ID.scrollTop -= this.ClientScroll
            }
            this.ID.scrollTop += this.Step
        }
        break;
    case 1:
        this.CTL += this.Step;
        if (this.CTL >= this.ScrollStep && this.DelayTime > 0) {
            this.ID.scrollTop -= this.ScrollStep + this.Step - this.CTL;
            this.Pause();
            return
        } else {
            if (this.ID.scrollTop <= 0) {
                this.ID.scrollTop += this.ClientScroll
            }
            this.ID.scrollTop -= this.Step
        }
        break;
    case 2:
        this.CTL += this.Step;
        if (this.CTL >= this.ScrollStep && this.DelayTime > 0) {
            this.ID.scrollLeft += this.ScrollStep + this.Step - this.CTL;
            this.Pause();
            return
        } else {
            if (this.ID.scrollLeft >= this.ClientScroll) {
                this.ID.scrollLeft -= this.ClientScroll
            }
            this.ID.scrollLeft += this.Step
        }
        break;
    case 3:
        this.CTL += this.Step;
        if (this.CTL >= this.ScrollStep && this.DelayTime > 0) {
            this.ID.scrollLeft -= this.ScrollStep + this.Step - this.CTL;
            this.Pause();
            return
        } else {
            if (this.ID.scrollLeft <= 0) {
                this.ID.scrollLeft += this.ClientScroll
            }
            this.ID.scrollLeft -= this.Step
        }
        break
    }
};
var popup_browser = navigator.appName;
var popup_b_version = navigator.appVersion;
var popup_version = popup_b_version.split(";");
var popup_trin_version_flag = popup_version && popup_version.length > 1;
var popup_trim_Version = popup_trin_version_flag ? popup_version[1].replace(/[ ]/g, "") : "";
var popup_uam_dataType = "json";
var popup_uam_type = "POST";
if (popup_browser == "Microsoft Internet Explorer" && popup_trim_Version == "MSIE7.0") {
    popup_uam_dataType = "jsonp";
    popup_uam_type = "GET"
} else {
    if (popup_browser == "Microsoft Internet Explorer" && popup_trim_Version == "MSIE8.0") {
        popup_uam_dataType = "jsonp";
        popup_uam_type = "GET"
    } else {
        if (popup_browser == "Microsoft Internet Explorer" && popup_trim_Version == "MSIE9.0") {
            popup_uam_dataType = "jsonp";
            popup_uam_type = "GET"
        }
    }
}
var popup_passport_appId = "otn";
var popup_passport_baseUrl = "https://kyfw.12306.cn/passport/";
var popup_passport_apptk_static = popup_passport_baseUrl + "web/auth/uamtk-static";
var popup_passport_login = popup_passport_baseUrl + "web/login";
var popup_passport_captcha = popup_passport_baseUrl + "captcha/captcha-image64?login_site=E&module=login&rand=sjrand&";
var popup_passport_captcha_check = popup_passport_baseUrl + "captcha/captcha-check";
var popup_passport_uamtk = popup_passport_baseUrl + "web/auth/uamtk";
var popup_is_uam_login = "Y";
var popup_is_login_passCode = "Y";
var popup_is_sweep_login = "Y";
var popup_is_login = "N";
var popup_baseUrl = "https://kyfw.12306.cn";
var popup_publicName = "/otn";
var base_uamauthclient_url = popup_baseUrl + popup_publicName + "/uamauthclient";
var popup_loginCallBack = function() {
    if (!$.popup_isPop) {
        window.location.href = popup_baseUrl + popup_publicName + "/login/userLogin"
    } else {
        if ("Y" == popup_is_uam_login) {
            $.ajax({
                type: "POST",
                url: popup_passport_uamtk,
                async: false,
                data: {
                    appid: popup_passport_appId
                },
                dataType: "jsonp",
                jsonp: "callback",
                success: function(a) {
                    if (a.result_code == 0) {
                        var b = a.newapptk || a.apptk;
                        $.ajax({
                            type: "POST",
                            async: false,
                            url: base_uamauthclient_url,
                            data: {
                                tk: b
                            },
                            datatype: "json",
                            success: function(c) {
                                if (c.result_code == 0) {
                                    $(".mask").fadeOut();
                                    $(".modal-login").hide();
                                    if ($.pop_secretStr && $.pop_start_time) {
                                        $.todo_submitOrderRe($.pop_secretStr, $.pop_start_time)
                                    }
                                }
                            },
                            error: function() {}
                        })
                    }
                },
                error: function() {}
            })
        } else {
            $(".mask").fadeOut();
            $(".modal-login").hide();
            if ($.pop_secretStr && $.pop_start_time) {
                $.todo_submitOrderRe($.pop_secretStr, $.pop_start_time)
            }
            if (typeof $.pop_callback === "function") {
                $.pop_callback()
            }
        }
    }
};
var popup_loginedCallBack = function() {
    if (!$.popup_isPop) {
        window.location.href = popup_baseUrl + popup_publicName + "/view/index.html"
    }
};
var popup_qr_appId = "otn";
var popup_url = {
    loginConf: popup_baseUrl + popup_publicName + "/login/conf",
    getPassCodeNew: popup_baseUrl + popup_publicName + "/passcodeNew/getPassCodeNew?module=login&rand=sjrand&",
    checkRandCodeAnsyn: popup_baseUrl + popup_publicName + "/passcodeNew/checkRandCodeAnsyn",
    login: popup_baseUrl + popup_publicName + "/login/loginAysnSuggest",
    getBanners: popup_baseUrl + popup_publicName + "/index12306/getLoginBanner",
    qr: popup_baseUrl + "/passport/web/create-qr",
    qr64: popup_baseUrl + "/passport/web/create-qr64",
    checkqr: popup_baseUrl + "/passport/web/checkqr"
};
var popup_defaultPasscodeHeight = 30;
var popup_ifSuccessCode = false;
var popup_passCodeImg = $("#J-loginImg");
var popup_ispopup_CreateQr = false;
var popup_t = null,
popup_s = "-1";
var popup_isPopupLogin = true;
var forie = "forie.html";
jQuery.extend({
    pop_secretStr: "",
    pop_start_time: "",
    popup_isPop: true,
    pop_callback: function() {},
    popup_show_login_error: function(a) {
        if ("验证码错误！" != a && "请选择验证码！" != a) {
            $("#J-password").val("")
        }
        $("#J-login-error").show().find("span").html(a)
    },
    popup_hide_login_error: function() {
        $("#J-login-error").hide().find("span").html("")
    },
    popup_loginForUam: function() {
        var a = "";
        var c = $("#J-passCodeCoin div");
        for (var b = 0; b < c.length; b++) {
            a += $(c[b]).attr("randcode") + ","
        }
        a = a.substring(0, a.length - 1);
        $.ajax({
            crossDomain: true,
            url: popup_passport_login,
            data: {
                username: $("#J-userName").val(),
                password: $("#J-password").val(),
                appid: popup_passport_appId,
                answer: a
            },
            dataType: popup_uam_dataType,
            type: popup_uam_type,
            timeout: 10000,
            xhrFields: {
                withCredentials: true
            },
            success: function(d) {
                if (d.result_code == 0) {
                    $.popup_hideCommonLogin();
                    popup_loginCallBack()
                } else {
                    $.popup_show_login_error(d.result_message);
                    $.popup_createPassCode();
                    $("#J-passCodeCoin").html("")
                }
            },
            error: function() {
                $.popup_hideCommonLogin()
            }
        })
    },
    popup_loginForLocation_passcode: function() {
        var a = "";
        var c = $("#J-passCodeCoin div");
        for (var b = 0; b < c.length; b++) {
            a += $(c[b]).attr("randcode") + ","
        }
        a = a.substring(0, a.length - 1);
        $("#J-passCodeCoin").html("");
        $.ajax({
            url: popup_url.login,
            data: {
                "loginUserDTO.user_name": $("#J-userName").val(),
                "userDTO.password": $("#J-password").val(),
                randCode: a
            },
            type: "POST",
            timeout: 10000,
            success: function(d) {
                var e = d.data;
                if (e && e.loginCheck == "Y") {
                    $.popup_hideCommonLogin();
                    popup_loginCallBack()
                } else {
                    if (e && e.message) {
                        $.popup_show_login_error(e.message);
                        $.popup_createPassCode_location();
                        $("#J-passCodeCoin").html("")
                    } else {
                        if (d.messages) {
                            $.popup_show_login_error(d.messages);
                            $.popup_createPassCode_location();
                            $("#J-passCodeCoin").html("")
                        } else {
                            $.popup_hideCommonLogin()
                        }
                    }
                }
            },
            error: function(d) {
                $.popup_hideCommonLogin()
            }
        })
    },
    popup_loginForLocation: function() {
        $.ajax({
            url: popup_url.login,
            data: {
                "loginUserDTO.user_name": $("#J-userName").val(),
                "userDTO.password": $("#J-password").val()
            },
            type: "POST",
            timeout: 10000,
            success: function(a) {
                var b = a.data;
                if (b && b.loginCheck == "Y") {
                    $.popup_hideCommonLogin();
                    popup_loginCallBack()
                } else {
                    if (b && b.message) {
                        $.popup_show_login_error(b.message)
                    } else {
                        if (a.messages) {
                            $.popup_show_login_error(a.messages)
                        } else {
                            $.popup_hideCommonLogin()
                        }
                    }
                }
            },
            error: function(a) {
                $.popup_hideCommonLogin()
            }
        })
    },
    popup_hideCommonLogin: function() {
        $("#J-userName").val("");
        $("#J-password").val("");
        $("#J-passCodeCoin").html("");
        $("#J-login-error").hide()
    },
    popup_showLoginType: function(a) {
        $("#J-loginImg").hide();
        $(".lgcode-error").hide();
        $(".lgcode-loading").hide();
        $(".lgcode-loading img").hide();
        $(".lgcode-success").hide();
        if (0 == a) {
            $("#J-loginImg").show()
        } else {
            if (1 == a) {
                $(".lgcode-error").show()
            } else {
                if (2 == a) {
                    $(".lgcode-success").show()
                } else {
                    if (3 == a) {
                        $(".lgcode-loading").show();
                        $(".lgcode-loading img").show()
                    }
                }
            }
        }
    },
    popup_getClickPos: function(d) {
        var g = (navigator.appName == "Netscape") ? d.pageX: d.clientX + (document.documentElement.scrollLeft || window.pageXOffset || document.body.scrollLeft);
        var b = (navigator.appName == "Netscape") ? d.pageY: d.clientY + (document.documentElement.scrollTop || window.pageYOffset || document.body.scrollTop);
        identifyImage = document.getElementById("J-loginImg");
        img_x = $.popup_locationLeft(identifyImage);
        img_y = $.popup_locationTop(identifyImage);
        var f = g - img_x;
        var c = b - img_y - popup_defaultPasscodeHeight;
        if (f > 0 && c > 0) {
            var a = '<div randCode="' + f + "," + c + '" class="lgcode-active" style="top: ' + (c + 16) + "px; left: " + (f - 13) + 'px;"></div>';
            $("#J-passCodeCoin").append(a)
        }
        $(".lgcode-active").click(function(h) {
            $(this).remove();
            h.stopPropagation()
        })
    },
    popup_locationLeft: function(a) {
        offsetTotal = a.offsetLeft;
        scrollTotal = 0;
        if (a.tagName != "BODY") {
            if (a.offsetParent != null) {
                return offsetTotal + scrollTotal + $.popup_locationLeft(a.offsetParent)
            }
        }
        return offsetTotal + scrollTotal
    },
    popup_locationTop: function(a) {
        offsetTotal = a.offsetTop;
        scrollTotal = 0;
        if (a.tagName != "BODY") {
            if (a.offsetParent != null) {
                return offsetTotal + scrollTotal + $.popup_locationTop(a.offsetParent)
            }
        }
        return offsetTotal + scrollTotal
    },
    popup_initLogin: function(b) {
        var a = false;
        if (popup_browser == "Microsoft Internet Explorer" && popup_trim_Version == "MSIE7.0") {
            a = true
        } else {
            if (popup_browser == "Microsoft Internet Explorer" && popup_trim_Version == "MSIE6.0") {
                a = true
            }
        }
        if (a) {
            location.href = forie;
            return
        }
        $.popup_isPop = b;
        popup_isPopupLogin = b;
        $.popup_hideCommonLogin();
        $.popup_showLoginType(3);
        $.popup_getConf();
        $("#J-userName").focus(function() {
            $.popup_hide_login_error()
        });
        $("#J-password").focus(function() {
            $.popup_hide_login_error()
        });
        $.popup_switchLoginWay();
        $.popup_refreshQrCode();
        $(".lgcode-refresh").unbind("click").click(function() {
            $(".lgcode-refresh").addClass("lgcode-refresh-click");
            if (popup_is_uam_login == "Y") {
                $.popup_refreshPassCode(false)
            } else {
                $.popup_refreshPassCode_location(false)
            }
            setTimeout(function() {
                $(".lgcode-refresh").removeClass("lgcode-refresh-click")
            },
            100)
        });
        $("#J-loginImgArea").unbind("click").click(function(c) {
            $.popup_getClickPos(c)
        })
    },
    popup_getConf: function() {
        $.ajax({
            url: popup_url.loginConf,
            type: "POST",
            timeout: 10000,
            success: function(a) {
                var b = a.data;
                if (b) {
                    popup_is_uam_login = b.is_uam_login;
                    popup_is_login_passCode = b.is_login_passCode;
                    popup_is_sweep_login = b.is_sweep_login;
                    popup_is_login = b.is_login;
                    $.popup_isLogin()
                }
            },
            error: function(a) {}
        })
    },
    popup_isLogin: function() {
        if (popup_is_uam_login == "Y") {
            if (popup_isPopupLogin) {
                $.popup_uamIsShowQr()
            } else {
                $.popup_uamIsLogin()
            }
        } else {
            if (popup_is_login == "Y") {
                popup_loginedCallBack()
            } else {
                $.popup_hideQrCode();
                $(".login-account").show();
                if (popup_is_login_passCode == "Y") {
                    $.popup_showPasscode();
                    $.popup_createPassCode_location()
                } else {
                    $.popup_hidePasscode();
                    $.popup_resetLoginBox()
                }
                $.popup_validate()
            }
        }
    },
    popup_resetLoginBox: function() {
        var a = $(".login-panel .login-box");
        a.css("margin-top", -a.outerHeight() / 2)
    },
    popup_uamIsLogin: function() {
        $.ajax({
            url: popup_passport_apptk_static,
            data: {
                appid: popup_passport_appId
            },
            type: "POST",
            xhrFields: {
                withCredentials: true
            },
            timeout: 10000,
            success: function(a) {
                if (a.result_code == "0") {
                    popup_loginedCallBack()
                } else {
                    $.popup_uamIsShowQr()
                }
            },
            error: function(a) {}
        })
    },
    popup_uamIsShowQr: function() {
        if (popup_is_sweep_login == "Y") {
            $.popup_showQrCode();
            $("#J-login-code-loading").show();
            $("#J-login-code-con").hide();
            $.popup_hideQrError();
            $.popup_createQr()
        } else {
            $.popup_hideQrCode();
            $(".login-account").show();
            $.popup_createPassCode()
        }
        $.popup_validate()
    },
    popup_createQr: function() {
        $.ajax({
            url: popup_url.qr64,
            data: {
                appid: popup_qr_appId
            },
            type: "POST",
            timeout: 10000,
            success: function(a) {
                if (a && a.result_code === "0" && a.image) {
                    $("#J-qrImg").attr("src", "data:image/jpg;base64," + a.image);
                    $("#J-login-code-loading").hide();
                    $("#J-login-code-con").show();
                    $("#J-code-error-mask").hide();
                    $("#J-code-error").hide();
                    popup_t = null;
                    popup_s = -1;
                    popup_t = setInterval(function() {
                        if (popup_s == "2" || popup_s == "3") {
                            clearInterval(popup_t)
                        } else {
                            $.popup_checkQr(a.uuid)
                        }
                    },
                    1000)
                } else {}
            },
            error: function(a) {}
        })
    },
    popup_checkQr: function(a) {
        $.ajax({
            url: popup_url.checkqr,
            data: {
                uuid: a,
                appid: popup_qr_appId
            },
            type: "POST",
            timeout: 10000,
            success: function(b) {
                if (b) {
                    popup_s = b.result_code;
                    $.popup_tipsQrInfo(parseInt(b.result_code))
                }
            },
            error: function(b) {}
        })
    },
    popup_showQrError: function(a) {
        $("#J-code-error-mask").show();
        $("#J-code-error").show();
        $("#J-code-error").find("p").html(a)
    },
    popup_hideQrError: function() {
        $("#J-code-error-mask").hide();
        $("#J-code-error").hide()
    },
    popup_showQrLoading: function() {
        $(".login-code-loading").show();
        $(".login-code-con").hide()
    },
    popup_hideQrLoading: function() {
        $(".login-code-loading").hide();
        $(".login-code-con").show()
    },
    popup_tipsQrInfo: function(c) {
        var b = $("#J-code-error-mask"),
        d = $("#J-code-error"),
        a = $("#J-login-code-con"),
        e = $("#J-login-code-success");
        if (c == 0) {
            b.hide();
            d.hide()
        } else {
            b.show();
            d.show();
            switch (c) {
            case 1:
                a.hide();
                e.removeClass("hide");
                break;
            case 2:
                a.hide();
                e.removeClass("hide");
                popup_loginCallBack();
                break;
            case 3:
                a.show();
                d.find("p").html("二维码已失效");
                d.find("a").show();
                e.addClass("hide");
                break;
            case 5:
                a.show();
                d.find("p").html("系统异常");
                d.find("a").show();
                e.addClass("hide");
                break;
            default:
                d.find("p").html("二维码已失效");
                d.find("a").show();
                e.addClass("hide")
            }
        }
    },
    popup_validate: function() {
        $("#J-login").click(function() {
            var e = $("#J-userName").val();
            var c = $("#J-password").val();
            var b = /^(13[0-9])|(14[0-9])|(15[0-9])|(18[0-9])|(17[0-9])\d{8}$/;
            var a = /^[A-Za-z]{1}([A-Za-z0-9]|[_]) {0,29}$/;
            var d = /^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$/i;
            if (!e) {
                $.popup_show_login_error("请输入用户名！");
                return false
            }
            if (!c) {
                $.popup_show_login_error("请输入密码！");
                return false
            }
            if (c && c.length < 6) {
                $.popup_show_login_error("密码长度不能少于6位！");
                return false
            }
            if (popup_is_login_passCode == "Y") {
                if ($("#J-passCodeCoin div").length == 0) {
                    $.popup_show_login_error("请选择验证码！");
                    return false
                }
            } else {
                popup_ifSuccessCode = true
            }
            $.popup_login()
        })
    },
    popup_login: function() {
        if (!popup_ifSuccessCode) {
            if (popup_is_uam_login == "Y") {
                $.popup_checkPassCode()
            } else {
                $.popup_checkPassCode_location()
            }
        } else {
            if (popup_is_uam_login == "Y") {
                $.popup_loginForUam()
            } else {
                if (popup_is_login_passCode == "Y") {
                    $.popup_checkPassCode_location()
                } else {
                    $.popup_loginForLocation()
                }
            }
        }
    },
    popup_showQrCode: function() {
        $(".login-box").removeClass("login-box-account");
        $(".login-code").show()
    },
    popup_hideQrCode: function() {
        $(".login-box").addClass("login-box-account");
        $(".login-code").hide()
    },
    popup_refreshQrCode: function() {
        $(".code-error .btn").unbind("click").click(function() {
            $("#J-login-code-loading").show();
            $("#J-login-code-con").hide();
            $.popup_hideQrError();
            $.popup_createQr()
        })
    },
    popup_switchLoginWay: function() {
        $(".login-hd-code a").unbind("click").click(function() {
            $("#J-login-code-loading").show();
            $("#J-login-code-con").hide();
            $.popup_hideQrError();
            $("#J-login-code-success").addClass("hide");
            $.popup_hideCommonLogin();
            if (popup_t) {
                clearInterval(popup_t);
                popup_t = null;
                popup_s = -1
            }
            $.popup_createQr()
        });
        $(".login-hd-account a").unbind("click").click(function() {
            $("#J-passCodeCoin").html("");
            if (popup_t) {
                clearInterval(popup_t);
                popup_t = null;
                popup_s = -1
            }
            $.popup_createPassCode()
        })
    },
    popup_createPassCode: function() {
        var a = new Date().getTime();
        $.ajax({
            url: popup_passport_captcha + a,
            xhrFields: {
                withCredentials: true
            },
            type: "GET",
            timeout: 10000,
            dataType: "jsonp",
            success: function(b) {
                if (b.image) {
                    popup_ifSuccessCode = false;
                    popup_passCodeImg.attr("src", "data:image/jpg;base64," + b.image);
                    $.popup_showLoginType(0)
                }
            },
            error: function(b) {}
        })
    },
    popup_createPassCode_location: function() {
        popup_ifSuccessCode = false;
        var a = new Date().getTime();
        popup_passCodeImg.attr("src", popup_url.getPassCodeNew + a);
        $.popup_showLoginType(0)
    },
    popup_checkPassCode: function() {
        var a = false;
        var b = "";
        var d = $("#J-passCodeCoin div");
        for (var c = 0; c < d.length; c++) {
            b += $(d[c]).attr("randcode") + ","
        }
        b = b.substring(0, b.length - 1);
        $.ajax({
            url: popup_passport_captcha_check,
            xhrFields: {
                withCredentials: true
            },
            crossDomain: true,
            data: {
                answer: b,
                rand: "sjrand",
                login_site: "E"
            },
            dataType: "jsonp",
            type: "GET",
            timeout: 10000,
            success: function(e) {
                if (e.result_code == 4) {
                    popup_ifSuccessCode = true;
                    $.popup_showLoginType(2);
                    $.popup_loginForUam()
                } else {
                    $.popup_passCodeError()
                }
            },
            error: function(e) {}
        })
    },
    popup_checkPassCode_location: function() {
        var a = false;
        var b = "";
        var d = $("#J-passCodeCoin div");
        for (var c = 0; c < d.length; c++) {
            b += $(d[c]).attr("randcode") + ","
        }
        b = b.substring(0, b.length - 1);
        $.ajax({
            url: popup_url.checkRandCodeAnsyn,
            xhrFields: {
                withCredentials: true
            },
            data: {
                randCode: b,
                rand: "sjrand",
                login_site: "E"
            },
            type: "POST",
            timeout: 10000,
            success: function(e) {
                var f = e.data;
                if (f && f.result == 1) {
                    popup_ifSuccessCode = true;
                    $.popup_showLoginType(2);
                    $.popup_loginForLocation_passcode()
                } else {
                    $.popup_passCodeError_location()
                }
            },
            error: function(e) {}
        })
    },
    popup_passCodeError: function() {
        $.popup_show_login_error("验证码错误！");
        $.popup_refreshPassCode(true)
    },
    popup_passCodeError_location: function() {
        $.popup_show_login_error("验证码错误！");
        $.popup_refreshPassCode_location(true)
    },
    popup_refreshPassCode: function(a) {
        $.popup_hide_login_error();
        $("#J-passCodeCoin").html("");
        if (a) {
            $.popup_showLoginType(1);
            setTimeout("$.popup_createPassCode()", 1000)
        } else {
            $.popup_createPassCode()
        }
    },
    popup_refreshPassCode_location: function(a) {
        $.popup_hide_login_error();
        $("#J-passCodeCoin").html("");
        if (a) {
            $.popup_showLoginType(1);
            setTimeout("$.popup_createPassCode_location()", 1000)
        } else {
            $.popup_createPassCode_location()
        }
    },
    popup_showPasscode: function() {
        $(".login-box").removeClass("login-box-account-nocode")
    },
    popup_hidePasscode: function() {
        $(".login-box").addClass("login-box-account-nocode")
    },
    popup_clearInterval: function() {
        if (popup_t) {
            clearInterval(popup_t);
            popup_t = null;
            popup_s = -1
        }
    },
    getBanners: function() {
        $.ajax({
            url: popup_url.getBanners,
            type: "GET",
            timeout: 10000,
            dataType: "text",
            success: function(a) {
                if (a) {
                    var b = JSON.parse(a);
                    $.each(b.data.index_banner_url,
                    function(c, e) {
                        var d = e.src ? '<a href="' + e.src + '"></a>': "<a style='cursor:auto;' href='javascript:void(0)'></a>";
                        $(".loginSlide .bd ul").append('<li style="background: url(' + e.url + ') center center no-repeat;">' + d + "</li>")
                    });
                    $(".loginSlide").slide({
                        titCell: ".hd ul",
                        mainCell: ".bd ul",
                        effect: "leftLoop",
                        vis: "auto",
                        autoPlay: true,
                        autoPage: true,
                        trigger: "click",
                        interTime: "6000"
                    })
                }
            },
            error: function(a) {}
        })
    }
});