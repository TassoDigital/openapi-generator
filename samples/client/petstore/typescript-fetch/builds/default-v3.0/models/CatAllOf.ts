/* tslint:disable */
/* eslint-disable */
/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface CatAllOf
 */
export interface CatAllOf {
    /**
     * 
     * @type {boolean}
     * @memberof CatAllOf
     */
    declawed?: boolean;
}

/**
 * Check if a given object implements the CatAllOf interface.
 */
export function instanceOfCatAllOf(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function CatAllOfFromJSON(json: any): CatAllOf {
    return CatAllOfFromJSONTyped(json, false);
}

export function CatAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): CatAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'declawed': !exists(json, 'declawed') ? undefined : json['declawed'],
    };
}

export function CatAllOfToJSON(value?: CatAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'declawed': value.declawed,
    };
}

