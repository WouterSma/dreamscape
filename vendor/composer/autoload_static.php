<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInitf452e15562d44f6ab98139f38bc45d05
{
    public static $prefixLengthsPsr4 = array (
        'F' => 
        array (
            'Firebase\\JWT\\' => 13,
        ),
    );

    public static $prefixDirsPsr4 = array (
        'Firebase\\JWT\\' => 
        array (
            0 => __DIR__ . '/..' . '/firebase/php-jwt/src',
        ),
    );

    public static $classMap = array (
        'Composer\\InstalledVersions' => __DIR__ . '/..' . '/composer/InstalledVersions.php',
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixLengthsPsr4 = ComposerStaticInitf452e15562d44f6ab98139f38bc45d05::$prefixLengthsPsr4;
            $loader->prefixDirsPsr4 = ComposerStaticInitf452e15562d44f6ab98139f38bc45d05::$prefixDirsPsr4;
            $loader->classMap = ComposerStaticInitf452e15562d44f6ab98139f38bc45d05::$classMap;

        }, null, ClassLoader::class);
    }
}
