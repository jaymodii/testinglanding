
$(document).ready(function () {
    $('#country-drop').click(function () {
        debugger
        var CountryId = $(this).val();
        $.ajax({
            url: '/Landing/LandingPage',
            type: 'GET',
            data: { CountryId: CountryId },
            dataType: 'json',
            success: function (data) {
                debugger
                $("#city-drop").empty();

                //var cities = $('#city-drop').val();
                //cities.empty();
                var items = "";
                $.each(data, function (i, item) {
                    items += `<li>

                        <a class="dropdown-item" href="#">
                            <div class="form-check">
                                <input class="form-check-input" type="checkbox" value="" id=@item.CityId unchecked />
                                <label class="form-check-label" for=@item.CityId>@item.CityName</label>
                            </div>
                        </a>
                    </li>`

                });
                $("#city-drop").html(items);
            }
        });
    });
})