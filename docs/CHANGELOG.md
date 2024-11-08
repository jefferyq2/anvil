# Changelog
All notable changes to this project will be documented in this file.

## [3.3.2] - 2024-10-16
- Drop CSR extension fields not required as they can prevent issuance when validated by the CA

## [3.3.1] - 2024-08-08
- Fix typo in AcmeRenewalInfo which causes deserialization error
 
## [3.3.0] - 2024-08-08
- Generate ACME error for applicable non-ACME standard server responses (e.g. server busy, too many requests) to normalize error types
- Add optional Auto Retry on failed directory fetch

## [3.2.0] - 2024-05-06
- Implement ARI `replaces` Certificate ID support in order payload

## [3.1.0] - 2024-04-25
- Allow chain build where the only issuers is the root (no intermediates)
- Optionally skip chain build verification using known issuers
- Update content type detection to allow for malformed server responses

## [3.0.0] - 2023-05-01
- Renamed fork as Certify.ACME.Anvil to avoid confusion with the original Certes library
- Implement support for tkauth-01, TnAuthList challenges and TnAuthList CSRs

## [2.4.2] - 2022-12-15
- Add option to use intermediate closest to root when building PFX chain, instead of requiring a known root.

## [2.4.1] - 2022-08-29
- Add option for modern algs during PFX build to support OpenSSL 3.x compatibility by default

## [2.4.0] - 2022-04-04
- Target .net 6
- Make key alg public
- Remove strong naming

## [2.3.9] - 2021-10-21
- Relax dependency versions

## [2.3.8] - 2021-09-03
- Add CSR option for OCSP Must Staple
- EC keys don't support KeyEncipherment usage attribute

## [2.3.7] - 2021-07-22
- Optionally require all issuers in GetIssuers (e.g. don't throw an exception if issuer not found)
- Update support for different RSA key sizes

## [2.3.6] - 2021-07-13
### Added
- Support alternate RSA key sizes
### Changed
- Make AcmeException optional for GetIssuers if issuer not found in local store

## [2.3.5] - 2021-03-17
### Added
- Support alternate link relations ak.a Preferred Chain ([#232][i232])
- Implement external account binding support (library). ([#231][i231])
### Changed
- Packaging fork to *Webprofusion.Certes* nuget package.

## [2.3.4] - 2020-03-27
### Changed
- Add user-agent header to HTTP requests
- Removed support for `netstandard1.3`
- [CLI] Upgrade to `netcoreapp3.1`
### Added
- [CLI] Add options for algorithm in order finalize method

## [2.3.3] - 2018-12-16
### Changed
- Fix EC account key encoding [#173](https://github.com/fszlin/certes/issues/173)

## [2.3.2] - 2018-10-20
### Changed
- Implement `POST-as-GET` for loading ACME resources

### Changed
- Fix account key roll-over missing old key field [#154](https://github.com/fszlin/certes/issues/154)
- Update TLS-ALPN OID as [draft-03](https://tools.ietf.org/html/draft-ietf-acme-tls-alpn-03)

## [2.3.1] - 2018-10-16
### Changed
- Remove package reference to `System.Net.Http` ([#158][i158])
### Added
- [CLI] Add `--friendly-name` option to `cert pfx` command ([#145][i145])
- [CLI] Add `--issuer` option to `cert pfx` command ([#142][i142])

## [2.3.0] - 2018-06-15
### Added
- Support `tls-alpn-01` challenge ([#125][i125])
- Add `ACME` error details to exception messages ([#109][i109])

## [2.2.2] - 2018-05-31
### Changed
- Revert `Newtonsoft.Json` to `v10.0.3` for `PowerShell Core` ([#112][i112])

## [2.2.1] - 2018-05-15
### Added
- Strong name signing ([#106][i106])

## [2.2.0] - 2018-05-05
### Added
- Add `Challenge.Error` for challenge valdidation error ([#99][i99])

### Changed
- Fix certificate chain for PFX ([#100][i100])

## [2.1.0] - 2018-04-27
### Added
- Export full chain certification in PEM ([#87][i87])
- Support custom `HttpClient` ([#95][i95])

### Changed
- Encapsulating ACME errors in exceptions ([#65][i65])
- [CLI] Change argument ~~talent-id~~ to `tenant-id` ([#86][i86])

## [2.0.1] - 2018-03-17
### Added
- Add `Processing` status for challenges.

### Changed
- Fix `Content-Type` header for POST requests ([#76][i76])

## [2.0.0] - 2018-03-13
### Added
- [ACME v2](APIv2.md) support
- Add support for JSON web signature using ECDSA key

## [1.1.4] - 2018-03-04
### Changed
- Fix error when processing server response without `Content-Type` header
- Fix `full-chain-off` option for CLI

## [1.1.3] - 2017-11-23
### Changed
- Fix MissingFieldException when running with BouncyCastle v1.8.1.3 ([#22][i22])

## [1.1.2] - 2017-09-27
### Changed
- Fix CLI script error

## [1.1.1] - 2017-09-26
### Added
- Add build target for net47

## [1.1.0] - 2017-08-17
### Added
- Add `Directory` to replace `AcmeDirectory`
- Add support for deleting registration
- Add support for account key roll-over

### Changed
- Allow assigning SAN when creating `CertificationRequestBuilder` instances

## 1.0.7 - 2017-07-20
### Changed
- Fix error when parsing directory resource with *meta* property. ([#5][i5])

[1.1.0]: https://github.com/fszlin/certes/compare/v1.0.7...v1.1.0
[1.1.1]: https://github.com/fszlin/certes/compare/v1.1.0...v1.1.1
[1.1.2]: https://github.com/fszlin/certes/compare/v1.1.1...v1.1.2
[1.1.3]: https://github.com/fszlin/certes/compare/v1.1.2...v1.1.3
[1.1.4]: https://github.com/fszlin/certes/compare/v1.1.3...v1.1.4
[2.0.0]: https://github.com/fszlin/certes/compare/v1.1.4...v2.0.0
[2.0.1]: https://github.com/fszlin/certes/compare/v2.0.0...v2.0.1
[2.1.0]: https://github.com/fszlin/certes/compare/v2.0.1...v2.1.0
[2.2.0]: https://github.com/fszlin/certes/compare/v2.1.0...v2.2.0
[2.2.1]: https://github.com/fszlin/certes/compare/v2.2.0...v2.2.1
[2.2.2]: https://github.com/fszlin/certes/compare/v2.2.1...v2.2.2
[2.3.0]: https://github.com/fszlin/certes/compare/v2.2.2...v2.3.0
[2.3.1]: https://github.com/fszlin/certes/compare/v2.3.0...v2.3.1
[2.3.2]: https://github.com/fszlin/certes/compare/v2.3.1...v2.3.2
[2.3.2]: https://github.com/fszlin/certes/compare/v2.3.2...v2.3.3
[Unreleased]: https://github.com/fszlin/certes/compare/v2.3.3...HEAD

[i5]: https://github.com/fszlin/certes/issues/5
[i22]: https://github.com/fszlin/certes/issues/22
[i65]: https://github.com/fszlin/certes/issues/65
[i76]: https://github.com/fszlin/certes/issues/76
[i86]: https://github.com/fszlin/certes/issues/86
[i87]: https://github.com/fszlin/certes/issues/87
[i95]: https://github.com/fszlin/certes/issues/95
[i99]: https://github.com/fszlin/certes/issues/99
[i100]: https://github.com/fszlin/certes/issues/100
[i106]: https://github.com/fszlin/certes/issues/106
[i112]: https://github.com/fszlin/certes/issues/112
[i125]: https://github.com/fszlin/certes/issues/125
[i109]: https://github.com/fszlin/certes/issues/109
[i142]: https://github.com/fszlin/certes/issues/142
[i145]: https://github.com/fszlin/certes/issues/145
[i158]: https://github.com/fszlin/certes/issues/158
