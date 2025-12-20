> Źródło: [https://getbootstrap.com/docs/5.3/migration/](https://getbootstrap.com/docs/5.3/migration/)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/migration.mdx "View and edit this file on GitHub")

# Migrating to v5

Track and review changes to the Bootstrap source files, documentation, and components to help you migrate from v4 to v5.

On this page
   
**On this page**

---

* [v5.3.6](#v536)
  + [Dependencies](#dependencies)
* [v5.3.0](#v530)
  + [Helpers](#helpers)
  + [Utilities](#utilities)
* [v5.3.0-alpha2](#v530-alpha2)
  + [CSS variables](#css-variables)
  + [Color modes](#color-modes)
  + [Typography](#typography)
  + [Components](#components)
  + [Helpers](#helpers-1)
  + [Utilities](#utilities-1)
  + [Docs](#docs)
  + [Tooling](#tooling)
* [v5.3.0-alpha1](#v530-alpha1)
  + [Color modes!](#color-modes-1)
  + [CSS variables](#css-variables-1)
  + [Components](#components-1)
    - [Alert](#alert)
    - [List group](#list-group)
    - [Dropdowns](#dropdowns)
    - [Close button](#close-button)
    - [Navbar](#navbar)
  + [Progress bars](#progress-bars)
  + [Forms](#forms)
  + [Utilities](#utilities-2)
* [v5.2.0](#v520)
  + [Refreshed design](#refreshed-design)
  + [More CSS variables](#more-css-variables)
  + [New \_maps.scss](#new-_mapsscss)
  + [New utilities](#new-utilities)
  + [Additional changes](#additional-changes)
* [v5.1.0](#v510)
* [v5.0.0](#v500)
  + [Dependencies](#dependencies-1)
  + [Browser support](#browser-support)
  + [Documentation changes](#documentation-changes)
  + [Sass](#sass)
  + [Color system](#color-system)
  + [Grid updates](#grid-updates)
  + [Content, Reboot, etc](#content-reboot-etc)
  + [RTL](#rtl)
  + [Forms](#forms-1)
  + [Components](#components-2)
    - [Accordion](#accordion)
    - [Alerts](#alerts)
    - [Badges](#badges)
    - [Breadcrumbs](#breadcrumbs)
    - [Buttons](#buttons)
    - [Card](#card)
    - [Carousel](#carousel)
    - [Close button](#close-button-1)
    - [Collapse](#collapse)
    - [Dropdowns](#dropdowns-1)
    - [Jumbotron](#jumbotron)
    - [List group](#list-group-1)
    - [Navs and tabs](#navs-and-tabs)
    - [Navbars](#navbars)
    - [Offcanvas](#offcanvas)
    - [Pagination](#pagination)
    - [Popovers](#popovers)
    - [Spinners](#spinners)
    - [Toasts](#toasts)
    - [Tooltips](#tooltips)
  + [Utilities](#utilities-3)
  + [Helpers](#helpers-2)
  + [JavaScript](#javascript)

## v5.3.6

### Dependencies

* Migrated from Hugo to Astro for building our documentation

## v5.3.0

If you’re migrating from our previous alpha releases of v5.3.0, please review their changes in addition to this section.

### Helpers

* [Colored links](/docs/5.3/helpers/colored-links) once again have `!important` so they work better with our newly added link utilities.

### Utilities

* Added new `.d-inline-grid` [display utility](/docs/5.3/utilities/display).

## v5.3.0-alpha2

If you’re migrating from our previous alpha release of v5.3.0, please review the changes listed below.

### CSS variables

* Removed several duplicate and unused root CSS variables.

### Color modes

* Dark mode colors are now derived from our theme colors (e.g., `$primary`) in Sass, rather than color specific tints or shades (e.g., `$blue-300`). This allows for a more automated dark mode when customizing the default theme colors.
* Added Sass maps for generating theme colors for dark mode text, subtle background, and subtle border.
* [Snippet examples](/docs/5.3/examples/#snippets) are now ready for dark mode with updated markup and reduced custom styles.
* Added `color-scheme: dark` to dark mode CSS to change OS level controls like scrollbars
* Form validation `border-color` and text `color` states now respond to dark mode, thanks to new Sass and CSS variables.
* Dropped recently added form control background CSS variables and reassigned the Sass variables to use CSS variables instead. This simplifies the styling across color modes and avoids an issue where form controls in dark mode wouldn’t update properly.
* Our `box-shadow`s will once again always stay dark instead of inverting to white when in dark mode.
* Improved HTML and JavaScript for our color mode toggle script. The selector for changing the active SVG has been improved, and the markup made more accessible with ARIA attributes.
* Improved docs code syntax colors and more across light and dark modes.

### Typography

* We no longer set a color for `$headings-color-dark` or `--bs-heading-color` for dark mode. To avoid several problems of headings within components appearing the wrong color, we’ve set the Sass variable to `null` and added a `null` check like we use on the default light mode.

### Components

* Cards now have a `color` set on them to improve rendering across color modes.
* Added new `.nav-underline` variant for our navigation with a simpler bottom border under the active nav link. [See the docs for an example.](/docs/5.3/components/navs-tabs#underline)
* Navs now have new `:focus-visible` styles that better match our custom button focus styles.

### Helpers

* Added new `.icon-link` helper to quickly place and align Bootstrap Icons alongside a textual link. Icon links support our new link utilities, too.
* Added new focus ring helper for removing the default `outline` and setting a custom `box-shadow` focus ring.

### Utilities

* Renamed Sass and CSS variables `${color}-text` to `${color}-text-emphasis` to match their associated utilities.
* Added new `.link-body-emphasis` helper alongside our [colored links](/docs/5.3/helpers/colored-links). This creates a colored link using our color mode responsive emphasis color.
* Added new link utilities for link color opacity, underline offset, underline color, and underline opacity. [Explore the new links utilities.](/docs/5.3/utilities/link)
* CSS variable based `border-width` utilities have been reverted to set their property directly (as was done prior to v5.2.0). This avoids inheritance issues across nested elements, including tables.
* Added new `.border-black` utility to match our `.text-black` and `.bg-black` utilities.
* Deprecated The `.text-muted` utility and `$text-muted` Sass variable have been deprecated and replaced with `.text-body-secondary` and `$body-secondary-color`.

### Docs

* Examples are now displayed with the appropriate light or dark color mode as dictated by the setting in our docs. Each example has an individual color mode picker.
* Improved included JavaScript for live Toast demo.
* Added `twbs/examples` repo contents to the top of the Examples page.

### Tooling

* Added SCSS testing via True to help test our utilities API and other customizations.
* Replaced instances of our bootstrap-npm-starter project with the newer and more complete [twbs/examples repo](https://github.com/twbs/examples).

---

