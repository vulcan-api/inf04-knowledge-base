> Źródło: [https://getbootstrap.com/docs/5.3/utilities/visibility](https://getbootstrap.com/docs/5.3/utilities/visibility)



[View on GitHub](https://github.com/twbs/bootstrap/blob/v5.3.8/site/src/content/docs/utilities/visibility.mdx "View and edit this file on GitHub")

# Visibility

Control the visibility of elements, without modifying their display, with visibility utilities.

Set the `visibility` of elements with our visibility utilities. These utility classes do not modify the `display` value at all and do not affect layout – `.invisible` elements still take up space in the page.

Elements with the `.invisible` class will be hidden *both* visually and for assistive technology/screen reader users.

Apply `.visible` or `.invisible` as needed.

```html
<div class="visible">...</div>
<div class="invisible">...</div>
```

```html
// Class
.visible {
  visibility: visible !important;
}
.invisible {
  visibility: hidden !important;
}
```

## CSS

### Sass utilities API

Visibility utilities are declared in our utilities API in `scss/_utilities.scss`. [Learn how to use the utilities API.](/docs/5.3/utilities/api#using-the-api)

[scss/\_utilities.scss](https://github.com/twbs/bootstrap/blob/v5.3.8/scss/_utilities.scss)

```html
"visibility": (
  property: visibility,
  class: null,
  values: (
    visible: visible,
    invisible: hidden,
  )
),
```

