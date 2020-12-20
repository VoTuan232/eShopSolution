- File _ViewStartLayout: định nghĩa layout
	Nếu ko muốn dùng layout: sử dụng @{Layout = null} tại page html

- Render section: đẩy Script và Styles từ child to parent 

@RenderSection('Styles', false)
@RenderSection('Scripts', false)
@section Styles {
	<link/>
}

- @ViewData["Title"]
Pass value `Title` from child to parent