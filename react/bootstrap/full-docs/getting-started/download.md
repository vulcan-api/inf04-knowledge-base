> Źródło: [https://getbootstrap.com/docs/5.3/getting-started/download](https://getbootstrap.com/docs/5.3/getting-started/download)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/getting-started/download.mdx "View and edit this file on GitHub")

# Download

Download Bootstrap to get the compiled CSS and JavaScript, source code, or include it with your favorite package managers like npm, RubyGems, and more.

On this page
   
**On this page**

---

* [Compiled CSS and JS](#compiled-css-and-js)
* [Source files](#source-files)
* [Examples](#examples)
* [CDN via jsDelivr](#cdn-via-jsdelivr)
  + [Alternative CDNs](#alternative-cdns)
* [Package managers](#package-managers)
  + [npm](#npm)
  + [yarn](#yarn)
  + [Bun](#bun)
  + [RubyGems](#rubygems)
  + [Composer](#composer)
  + [NuGet](#nuget)
* [IntelliSense extension](#intellisense-extension)

## Compiled CSS and JS

Download ready-to-use compiled code for **Bootstrap v5.3.8** to easily drop into your project, which includes:

* Compiled and minified CSS bundles (see [CSS files comparison](/docs/5.3/getting-started/contents#css-files))
* Compiled and minified JavaScript plugins (see [JS files comparison](/docs/5.3/getting-started/contents#js-files))

This doesn’t include documentation, source files, or any optional JavaScript dependencies like Popper.

[Download](https://github.com/twbs/bootstrap/releases/download/v5.3.8/bootstrap-5.3.8-dist.zip)

## Source files

Compile Bootstrap with your own asset pipeline by downloading our source Sass, JavaScript, and documentation files. This option requires some additional tooling:

* [Sass compiler](/docs/5.3/getting-started/contribute#sass) for compiling Sass source files into CSS files
* [Autoprefixer](https://github.com/postcss/autoprefixer) for CSS vendor prefixing

Should you require our full set of [build tools](/docs/5.3/getting-started/contribute#tooling-setup), they are included for developing Bootstrap and its docs, but they’re likely unsuitable for your own purposes.

[Download source](https://github.com/twbs/bootstrap/archive/v5.3.8.zip)

## Examples

If you want to download and examine our [examples](/docs/5.3/examples), you can grab the already built examples:

[Download Examples](https://github.com/twbs/bootstrap/releases/download/v5.3.8/bootstrap-5.3.8-examples.zip)

## CDN via jsDelivr

Skip the download with [jsDelivr](https://www.jsdelivr.com/) to deliver cached version of Bootstrap’s compiled CSS and JS to your project.

```html
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
```

If you’re using our compiled JavaScript and prefer to include Popper separately, add Popper before our JS, via a CDN preferably.

```html
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.min.js" integrity="sha384-G/EV+4j2dNv+tEPo3++6LCgdCROaejBqfUeNjuKAiuXbjrxilcCdDz6ZAVfHWe1Y" crossorigin="anonymous"></script>
```

### Alternative CDNs

We recommend [jsDelivr](https://www.jsdelivr.com/) and use it ourselves in our documentation. However, in some cases—like in some specific countries or environments—you may need to use other CDN providers like [cdnjs](https://cdnjs.com/) or [unpkg](https://unpkg.com/).

You’ll find the same files on these CDN providers, albeit with different URLs. With cdnjs, you can [use this direct Bootstrap package link](https://cdnjs.com/libraries/bootstrap) to copy and paste ready-to-use HTML snippets for each dist file from any version of Bootstrap.

**If the SRI hashes differ for a given file, you shouldn’t use the files from that CDN, because it means that the file was modified by someone else.**

Note that you should compare same length hashes, e.g. `sha384` with `sha384`, otherwise it’s expected for them to be different.
As such, you can use an online tool like [SRI Hash Generator](https://www.srihash.org/) to make sure that the hashes are the same for a given file.
Alternatively, assuming you have OpenSSL installed, you can achieve the same from the CLI, for example:

```html
openssl dgst -sha384 -binary bootstrap.min.js | openssl base64 -A
```

## Package managers

Pull in Bootstrap’s **source files** into nearly any project with some of the most popular package managers. No matter the package manager, Bootstrap will **require a [Sass compiler](/docs/5.3/getting-started/contribute#sass) and [Autoprefixer](https://github.com/postcss/autoprefixer)** for a setup that matches our official compiled versions.

### npm

Install Bootstrap in your Node.js powered apps with [the npm package](https://www.npmjs.com/package/bootstrap):

```html
npm install bootstrap@5.3.8
```

`const bootstrap = require('bootstrap')` or `import bootstrap from 'bootstrap'` will load all of Bootstrap’s plugins onto a `bootstrap` object.
The `bootstrap` module itself exports all of our plugins. You can manually load Bootstrap’s plugins individually by loading the `/js/dist/*.js` files under the package’s top-level directory.

Bootstrap’s `package.json` contains some additional metadata under the following keys:

* `sass` - path to Bootstrap’s main [Sass](https://sass-lang.com/) source file
* `style` - path to Bootstrap’s non-minified CSS that’s been compiled using the default settings (no customization)

**Get started with Bootstrap via npm with our starter project!** Head to the [Sass & JS example](https://github.com/twbs/examples/tree/main/sass-js) template repository to see how to build and customize Bootstrap in your own npm project. Includes Sass compiler, Autoprefixer, Stylelint, PurgeCSS, and Bootstrap Icons.

### yarn

Install Bootstrap in your Node.js powered apps with [the yarn package](https://yarnpkg.com/en/package/bootstrap):

```html
yarn add bootstrap@5.3.8
```

**Yarn 2+ (aka Yarn Berry) doesn’t support the `node_modules` directory by default**: using our [Sass & JS example](https://github.com/twbs/examples/tree/main/sass-js) needs some adjustments:

```html
yarn config set nodeLinker node-modules # Use the node_modules linker
touch yarn.lock # Create an empty yarn.lock file
yarn install # Install the dependencies
yarn start # Start the project
```

### Bun

Install Bootstrap in your Bun or Node.js powered apps with [the Bun CLI](https://bun.sh/):

```html
bun add bootstrap@5.3.8
```

### RubyGems

Install Bootstrap in your Ruby apps using [Bundler](https://bundler.io/) (**recommended**) and [RubyGems](https://rubygems.org/) by adding the following line to your [`Gemfile`](https://bundler.io/guides/gemfile.html):

```html
gem 'bootstrap', '~> 5.3.8'
```

Alternatively, if you’re not using Bundler, you can install the gem by running this command:

```html
gem install bootstrap -v 5.3.8
```

[See the gem’s README](https://github.com/twbs/bootstrap-rubygem/blob/main/README.md) for further details.

### Composer

You can also install and manage Bootstrap’s Sass and JavaScript using [Composer](https://getcomposer.org/):

```html
composer require twbs/bootstrap:5.3.8
```

### NuGet

If you develop in .NET Framework, you can also install and manage Bootstrap’s [CSS](https://www.nuget.org/packages/bootstrap/) or [Sass](https://www.nuget.org/packages/bootstrap.sass/) and JavaScript using [NuGet](https://www.nuget.org/). Newer projects should use [libman](https://learn.microsoft.com/en-us/aspnet/core/client-side/libman/) or another method as NuGet is designed for compiled code, not frontend assets.

```html
Install-Package bootstrap
```

```html
Install-Package bootstrap.sass
```

## IntelliSense extension

![](/docs/5.3/assets/img/bootstrap-intellisense-autocomplete.png)

Install the community-maintained [IntelliSense extension](https://marketplace.visualstudio.com/items?itemName=hossaini.bootstrap-intellisense) for Visual Studio Code to get IntelliSense auto-completion for Bootstrap classes.

[View in VS Code Marketplace](https://marketplace.visualstudio.com/items?itemName=hossaini.bootstrap-intellisense)

