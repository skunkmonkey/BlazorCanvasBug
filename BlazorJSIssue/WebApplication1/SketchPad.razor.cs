using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;


namespace WebApplication1
{

	public partial class SketchPad
	{
		private ElementReference _canvasContainer1;
		private ElementReference _canvasContainer2;
		private ElementReference _canvasElement1;
		private ElementReference _canvasElement2;

		[Inject]
		IJSRuntime JSRuntime { get; set; }

		private void SwitchToView1()
		{
			IJSInProcessRuntime JS = (IJSInProcessRuntime)JSRuntime;
			JS.InvokeVoid("CanvasContext2D.init", new object[] { _canvasElement1 });
			JS.InvokeVoid("CanvasContext2D._context.moveTo", new object[] { 10, 10 });
			JS.InvokeVoid("CanvasContext2D._context.lineTo", new object[] { 300, 300 });
			JS.InvokeVoid("CanvasContext2D._context.stroke", null);
		}
		private void SwitchToView2()
		{
			IJSInProcessRuntime JS = (IJSInProcessRuntime)JSRuntime;
			JS.InvokeVoid("CanvasContext2D.init", new object[] { _canvasElement2 });
			JS.InvokeVoid("CanvasContext2D._context.moveTo", new object[] { 100, 100 });
			JS.InvokeVoid("CanvasContext2D._context.lineTo", new object[] { 100, 300 });
			JS.InvokeVoid("CanvasContext2D._context.stroke", null);
		}
	}
}
