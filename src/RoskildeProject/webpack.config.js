var path = require('path');
var webpack = require('webpack');
var react = require('react');

module.exports = {
    entry: './wwwroot/components/entry.js',
    output: {
        path: './wwwroot',
        filename: 'bundle.js'

    },

    module: {
        loaders: [
            {
                test: /.jsx?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    external: {
        react: 'React'
    }
}

module.exports = {
    entry: './wwwroot/components/entry-search-results.js',
    output: {
        path: './wwwroot',
        filename: 'search-bundle.js'

    },

    module: {
        loaders: [
            {
                test: /.jsx?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    external: {
        react: 'React'
    },
    plugins: [
    new webpack.ProvidePlugin({
        $: "jquery",
        jQuery: "jquery"
    })
    ]
}

module.exports = {
    entry: './wwwroot/components/entry-filter-box.js',
    output: {
        path: './wwwroot',
        filename: 'search-bundle.js'
    },

    module: {
        loaders: [
            {
                test: /.jsx?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    external: {
        react: 'React'
    },
    plugins: [
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery"
        })
    ]
}

module.exports = {
    entry: './wwwroot/js/entry-mainpage.js',
    output: {
        path: './wwwroot',
        filename: 'mainpage-bundle.js'
    },

    module: {
        loaders: [
            {
                test: /.jsx?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    external: {
        react: 'React'
    },
    plugins: [
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery"
        })
    ]
}

module.exports = {
    entry: './wwwroot/components/entry-recently-item.js',
    output: {
        path: './wwwroot',
        filename: 'mainpage-bundle.js'

    },

    module: {
        loaders: [
            {
                test: /.jsx?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    },
    external: {
        react: 'React'
    },
    plugins: [
    new webpack.ProvidePlugin({
        $: "jquery",
        jQuery: "jquery"
    })
    ]
}