> Źródło: [https://getbootstrap.com/docs/5.3/customize/overview](https://getbootstrap.com/docs/5.3/customize/overview)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/customize/overview.mdx "View and edit this file on GitHub")

# Customize

Learn how to theme, customize, and extend Bootstrap with Sass, a boatload of global options, an expansive color system, and more.

[**Sass** Utilize our source Sass files to take advantage of variables, maps, mixins, and functions.](/docs/5.3/customize/sass/)

[**Options** Customize Bootstrap with built-in variables to easily toggle global CSS preferences.](/docs/5.3/customize/options/)

[**Color** Learn about and customize the color systems that support the entire toolkit.](/docs/5.3/customize/color/)

[**Color modes** Explore our default light mode and the new dark mode, or create custom color modes yourself.](/docs/5.3/customize/color-modes/)

[**Components** Learn how we build nearly all our components responsively and with base and modifier classes.](/docs/5.3/customize/components/)

[**CSS variables** Use Bootstrap’s CSS custom properties for fast and forward-looking design and development.](/docs/5.3/customize/css-variables/)

[**Optimize** Keep your projects lean, responsive, and maintainable so you can deliver the best experience.](/docs/5.3/customize/optimize/)

## Overview

There are multiple ways to customize Bootstrap. Your best path can depend on your project, the complexity of your build tools, the version of Bootstrap you’re using, browser support, and more.

Our two preferred methods are:

1. Using Bootstrap [via package manager](/docs/5.3/getting-started/download#package-managers) so you can use and extend our source files.
2. Using Bootstrap’s compiled distribution files or [jsDelivr](/docs/5.3/getting-started/download#cdn-via-jsdelivr) so you can add onto or override Bootstrap’s styles.

While we cannot go into details here on how to use every package manager, we can give some guidance on [using Bootstrap with your own Sass compiler](/docs/5.3/customize/sass).

For those who want to use the distribution files, review the [getting started page](/docs/5.3/getting-started/introduction) for how to include those files and an example HTML page. From there, consult the docs for the layout, components, and behaviors you’d like to use.

As you familiarize yourself with Bootstrap, continue exploring this section for more details on how to utilize our global options, making use of and changing our color system, how we build our components, how to use our growing list of CSS custom properties, and how to optimize your code when building with Bootstrap.

## CSPs and embedded SVGs

Several Bootstrap components include embedded SVGs in our CSS to style components consistently and easily across browsers and devices. **For organizations with more strict CSP configurations**, we’ve documented all instances of our embedded SVGs (all of which are applied via `background-image`) so you can more thoroughly review your options.

* [Accordion](/docs/5.3/components/accordion)
* [Carousel controls](/docs/5.3/components/carousel#with-controls)
* [Close button](/docs/5.3/components/close-button) (used in alerts and modals)
* [Form checkboxes and radio buttons](/docs/5.3/forms/checks-radios)
* [Form switches](/docs/5.3/forms/checks-radios#switches)
* [Form validation icons](/docs/5.3/forms/validation#server-side)
* [Navbar toggle buttons](/docs/5.3/components/navbar#responsive-behaviors)
* [Select menus](/docs/5.3/forms/select)

Based on [community conversation](https://github.com/twbs/bootstrap/issues/25394), some options for addressing this in your own codebase include [replacing the URLs with locally hosted assets](/docs/5.3/getting-started/webpack#extracting-svg-files), removing the images and using inline images (not possible in all components), and modifying your CSP. Our recommendation is to carefully review your own security policies and decide on the best path forward, if necessary.

