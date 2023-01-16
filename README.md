# Alpine.TagHelpers

[Alpine.js](https://alpinejs.dev) Tag Helper for ASP.NET Core Razor Views.

## Installation

```bash
dotnet add package Alpine.TagHelpers
```

## Usage

### `alpine-data` Tag Helper

Renders a .NET object as JavaScript (not JSON) object inside the Alpine `x-data` attribute.

Register the Tag Helpers in `_ViewImports.cshtml`

```text
@addTagHelper *, Alpine.TagHelpers
```

Use the `alpine-data` Tag Helper:

```html
<div alpine-data="new { Open = false }">
  <button x-on:click="open = !open">Show</button>
  <div x-show="open" x-cloak>Some details...</div>
</div>
```

Result:

```html
<div x-data="{open:false}">
  <button x-on:click="open = !open">Show</button>
  <div x-show="open">Some details...</div>
</div>
```

## Samples

Samples can be found inside the `samples` folder.

## License

MIT License

Copyright (c) 2023 Alexander Zeitler

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
