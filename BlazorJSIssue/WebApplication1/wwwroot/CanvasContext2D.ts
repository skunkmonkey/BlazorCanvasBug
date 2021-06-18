class CanvasContext2D {

    private _context: CanvasRenderingContext2D
    private _canvas: HTMLCanvasElement

    public init(canvas: HTMLCanvasElement) {
        this._canvas = canvas
        this._context = canvas.getContext("2d")
    }
}

(window as any).CanvasContext2D = new CanvasContext2D()