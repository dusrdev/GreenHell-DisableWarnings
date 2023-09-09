# DisableWarnings

One of the biggest performance issues of Green Hell is caused by excessive logging of warnings that create massive amounts of IO operations which are very costly on hardware resources.

This can be especially noticeable in Spirits of Amazonia, in which the game constantly tries to load and play non-existent or bugged audio files, that produce warnings and in turn cause terrible frame rate drops that make the game virtually unplayable.

This mod hooks into the game and intercepts all logging requests and cancels that ones that are warnings, essentially not allowing the game to request IO operations for them. It thus massively reduces the amount of IO operations and the performance cost associated with them.
